using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bludiste
{
    public partial class Bludiste : Form
    {
        Color barvaBludiste = Color.Gray;
        Color background = Color.Black;

        private bool fullscreen = false;
        private int hraloseSekund = -1;
        private int hraloseMinut = -1;
        private bool start = false;
        private DateTime startTime;
        private DateTime endTime;
        private bool cmaranice = false;
        private bool animovatbludiste = false;
        private int zdrzeni = 1;
        private int rozptyl = 30;
        private bool end = false;
        private const int odsazeniX = 30;
        private const int odsazeniY = 60;
        private Bunka hrac = null;
        private Bunka[,] bludiste;
        private Stack<Bunka> cesta = new Stack<Bunka>();

        private Point velikost = new Point();

        public Bludiste()
        {
            InitializeComponent();
            this.BackColor = background;

            RegistraceUdalosti();

            Timer t = new Timer();
            t.Tick += new EventHandler(t_Tick);
            t.Interval = 1000;
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            AktualizujCas();
        }

        private void RegistraceUdalosti()
        {
           this.Resize += new EventHandler(Bludiste_Resize);
           this.Paint += new PaintEventHandler(Bludiste_Paint);
           this.Shown += new EventHandler(Bludiste_Shown);
        }

        void Bludiste_Shown(object sender, EventArgs e)
        {
            GenerujBludiste();
            Invalidate();            
        }


        void Bludiste_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (!cmaranice && hrac != null)
            {
                float x = (Bunka.krokX * hrac.j) + 1 + odsazeniX;
                float y = (Bunka.krokY * hrac.i) + 1 + odsazeniY;

                g.FillEllipse(Brushes.Red, x, y, Bunka.krokX - 2, Bunka.krokY - 2);
            }

            KresliBludiste(g);
        }

        void Bludiste_Resize(object sender, EventArgs e)
        {
            
            int sirka = this.ClientSize.Width - (odsazeniX+30);
            int vyska = this.ClientSize.Height - (odsazeniY+30);

            double pomerX = ((double)sirka / (double)velikost.X);
            double pomerY = ((double)vyska / (double)velikost.Y);

            pomerX *= (double)Bunka.krokX;
            pomerY *= (double)Bunka.krokY;

            Bunka.krokX = (float)pomerX;
            Bunka.krokY = (float)pomerY;

            velikost = new Point(sirka, vyska);

            Invalidate();
        }

        private void AktualizujCas()
        {
            if (start && !end)
            {
                int casTed = (DateTime.Now.Hour*3600)+(DateTime.Now.Minute * 60) + DateTime.Now.Second;
                int casStartu = (startTime.Hour*3600)+(startTime.Minute * 60) + startTime.Second;
                int rozdil = casTed - casStartu;

                int minuty = (rozdil / 60);
                int sekundy = (rozdil - (minuty*60));

                hraloseSekund = sekundy;
                hraloseMinut = minuty;

                Cas.Text = Cas.Text.Remove(Cas.Text.IndexOf(":") + 2);

                string vm = (minuty <= 9)?"0"+minuty.ToString():minuty.ToString();
                string vs = (sekundy <= 9) ? "0" + sekundy.ToString() : sekundy.ToString();
                Cas.Text += vm + ":" + vs;
            }
        }

        private void KresliBludiste(Graphics g)
        {
            PointF p1 = new Point();
            PointF p2 = new Point();

            Pen p = new Pen(barvaBludiste, 3);

            if (bludiste != null)
            for (int i = 0; i < bludiste.GetLength(0); i++)
            {
                for (int j = 0; j < bludiste.GetLength(1); j++)
                {

                    Application.DoEvents();

                    #region renderuj levou caru
                    if (!bludiste[i, j].Pruchod[Bunka.Left])
                    {
                        //nahore v levo dolu
                        p1.Y = Bunka.krokY * i;
                        p1.Y += odsazeniY;
                        if (cmaranice)
                            p1.Y += rozptyl;
                        p2.Y = Bunka.krokY * (i + 1);
                        p2.Y += odsazeniY;
                        
                        p1.X = Bunka.krokX * j;
                        p1.X += odsazeniX;
                        if (cmaranice)
                            p1.X += rozptyl;
                        p2.X = Bunka.krokX * j;
                        p2.X += odsazeniX;

                        g.DrawLine(p, p1, p2);
                    }
                    #endregion
                    #region renderuj dolni caru
                    if (!bludiste[i, j].Pruchod[Bunka.Down])
                    {
                        //dole v levo doprava
                        p1.Y = Bunka.krokY * (i + 1);
                        p1.Y += odsazeniY;
                        if (cmaranice)
                            p1.Y += rozptyl;
                        p2.Y = Bunka.krokY * (i + 1);
                        p2.Y += odsazeniY;

                        p1.X = Bunka.krokX * j;
                        p1.X += odsazeniX;
                        if (cmaranice)
                            p1.X += rozptyl;
                        p2.X = Bunka.krokX * (j + 1);
                        p2.X += odsazeniX;

                        g.DrawLine(p, p1, p2);
                    }
                    #endregion
                    #region renderuj pravou caru
                    if (!bludiste[i, j].Pruchod[Bunka.Right])
                    {
                        //dole v pravo nahoru
                        p1.Y = Bunka.krokY * (i + 1);
                        p1.Y += odsazeniY;
                        if (cmaranice)
                            p1.Y += rozptyl;
                        p2.Y = Bunka.krokY * i;
                        p2.Y += odsazeniY;

                        p1.X = Bunka.krokX * (j + 1);
                        p1.X += odsazeniX;
                        if (cmaranice)
                            p1.X += rozptyl;
                        p2.X = Bunka.krokX * (j + 1);
                        p2.X += odsazeniX;

                        g.DrawLine(p, p1, p2);
                    }
                    #endregion
                    #region renderuj horni caru
                    if (!bludiste[i, j].Pruchod[Bunka.Up])
                    {
                        //nahore v pravo doleva
                        p1.Y = Bunka.krokY * i;
                        p1.Y += odsazeniY;
                        if (cmaranice)
                            p1.Y += rozptyl;
                        p2.Y = Bunka.krokY * i;
                        p2.Y += odsazeniY;

                        p1.X = Bunka.krokX * (j + 1);
                        p1.X += odsazeniX;
                        if (cmaranice)
                            p1.X += rozptyl;
                        p2.X = Bunka.krokX * j;
                        p2.X += odsazeniX;

                        g.DrawLine(p, p1, p2);
                    }
                    #endregion
                    
                    if (bludiste[i, j].konec && !cmaranice)
                    {
                        g.FillRectangle(Brushes.Blue, (Bunka.krokX * j)+odsazeniX, (Bunka.krokY * i)+odsazeniY, Bunka.krokX, Bunka.krokY);
                    }
                }
            }
        }

        private void GenerujBludiste()
        {
            start = false;
            end = false;

            int sirka = this.ClientSize.Width - (odsazeniX+30);
            int vyska = this.ClientSize.Height - (odsazeniY+30);
            nastavenivelikosti nv = new nastavenivelikosti();
            nv.originalniSirka = sirka;
            nv.originalniVyska = vyska;

            velikost = new Point(sirka, vyska);

            sirka = sirka / (int)Bunka.krokX;
            vyska = vyska / (int)Bunka.krokY;

            nv.krok.Value = Convert.ToDecimal((int)(((float)(Bunka.krokX+Bunka.krokY))/2f));

            nv.radky.Maximum = Convert.ToDecimal(vyska);
            nv.sloupce.Maximum = Convert.ToDecimal(sirka);
            nv.radky.Value = Convert.ToDecimal(vyska);
            nv.sloupce.Value = Convert.ToDecimal(sirka);

            DialogResult ukonceni = nv.ShowDialog();

            if (ukonceni == DialogResult.OK)
            {
                sirka = Convert.ToInt32(nv.sloupce.Value);
                vyska = Convert.ToInt32(nv.radky.Value);
                Bunka.krokY = Convert.ToInt32(nv.krok.Value);
                Bunka.krokX = Convert.ToInt32(nv.krok.Value);
            }
            else return;



            bludiste = new Bunka[vyska,sirka];

            for (int i = 0; i < vyska; i++)
            {
                for (int j = 0; j < sirka; j++)
                {
                    bludiste[i, j] = new Bunka();
                    bludiste[i, j].i = i;
                    bludiste[i, j].j = j;
                }
            }

            int mistovchodu = 0;
            Random rnd = new Random();
            
            //urcuje, zda bude vchod ze boku
            int smer = rnd.Next(0, 50);

            int vchodY = 0;
            int vchodX = 0;

            int smerVchodu = 0;

            if (smer > 25)
            {
                mistovchodu = rnd.Next(1, vyska-1);
                smerVchodu = Bunka.Left;

                vchodX = 0;
                vchodY = mistovchodu;
            }
            else
            {
                mistovchodu = rnd.Next(1, sirka-1);
                smerVchodu = Bunka.Up;

                vchodX = mistovchodu;
                vchodY = 0;

            }
            
            hrac = bludiste[vchodY, vchodX];

            cesta.Push(bludiste[vchodY, vchodX]);
            VybourejCestu(vchodY, vchodX, smerVchodu, Bunka.InverzniSmer(smerVchodu),rnd);

            ProbourejSteny(rnd);

        }

        private void ProbourejSteny(Random rnd)
        {
            Bunka pokracovaciBunka = cesta.Pop();
            do
            {
                if (pokracovaciBunka != null)
                {
                    bool[] pouzite = pokracovaciBunka.vratPouzitiSousednichBunek(bludiste);

                    int count = 0;
                    for (int m = 0; m < pouzite.Length; m++)
                        if (pouzite[m])
                            count++;

                    if (count == 4)
                    {
                        pokracovaciBunka = null;
                        continue;
                    }


                    bool[] otestovano = new bool[4];
                    int nahodnysmer = rnd.Next(0, 3);
                    Point p3 = Bunka.getNewPosition(pokracovaciBunka.i, pokracovaciBunka.j, nahodnysmer);
                    do
                    {

                        int g = 0;
                        for (int k = 0; k < otestovano.Length; k++)
                            if (otestovano[k])
                                g++;

                        if (g == 4)
                            break;

                        int irandom = rnd.Next(0, 1000);
                        if (irandom <= 250)
                            nahodnysmer = 0;
                        else if (irandom <= 500)
                            nahodnysmer = 1;
                        else if (irandom <= 750)
                            nahodnysmer = 2;
                        else if (irandom <= 1000)
                            nahodnysmer = 3;


                        p3 = Bunka.getNewPosition(pokracovaciBunka.i, pokracovaciBunka.j, nahodnysmer);

                        int counter = 0;
                        int correctSmer = -1;
                        for (int c = 0; c < pouzite.Length; c++)
                        {
                            if (pouzite[c])
                                counter++;
                            else correctSmer = c;

                        }

                        otestovano[nahodnysmer] = true;

                        if (counter == 3)
                        {
                            nahodnysmer = correctSmer;
                        }

                        

                    } while (pouzite[nahodnysmer] || !Bunka.jsemVBludisti(p3, bludiste));


                    Point p4 = Bunka.getNewPosition(pokracovaciBunka.i, pokracovaciBunka.j, nahodnysmer);

                    if (!Bunka.jsemVBludisti(p4, bludiste))
                    {
                        pokracovaciBunka = null;
                        continue;
                    }


                    for (int a = 0; a < pouzite.Length; a++)
                    {
                        if (a != nahodnysmer)
                        {
                            if (!pouzite[a])
                            {
                                Point p = Bunka.getNewPosition(pokracovaciBunka.i, pokracovaciBunka.j, a);
                                if (Bunka.jsemVBludisti(p, bludiste))
                                {
                                    cesta.Push(bludiste[p.Y, p.X]);
                                }
                            }
                        }
                    }

                    pokracovaciBunka.Pruchod[nahodnysmer] = true;
                    Point p2 = Bunka.getNewPosition(pokracovaciBunka.i, pokracovaciBunka.j, nahodnysmer);
                    pokracovaciBunka = bludiste[p2.Y, p2.X];
                    pokracovaciBunka.Pruchod[Bunka.InverzniSmer(nahodnysmer)] = true;

                    if (animovatbludiste)
                    {
                        Invalidate();
                        System.Threading.Thread.Sleep(zdrzeni);
                        Application.DoEvents();
                    }

                }
                else
                {
                    pokracovaciBunka = cesta.Pop();
                }

            } while (cesta.Count != 0);
        }

        /// <summary>
        /// Funkce vyboura tunel na konec
        /// </summary>
        /// <param name="i">vyskova pozice vstupu</param>
        /// <param name="j">horizontalni pozice vstupu</param>
        /// <param name="pruchod">urcuje smer, odkud se prislo</param>
        /// <param name="konec">urcuje, ve kterym smeru je idealni skoncit (nerika, at tak vzdy skonci, pouze idealni stav)</param>
        /// <param name="rnd">generator nahodnych cisel</param>
        public void VybourejCestu(int i, int j, int pruchod, int konec, Random rnd)
        {

            int smer = rnd.Next(0, 3);

            while (smer == pruchod)
                smer = rnd.Next(0, 3);

            while (smer == Bunka.Left && j == 0)
                smer = rnd.Next(0, 3);

            while (smer == Bunka.Up && i == 0)
                smer = rnd.Next(0, 3);

            if (smer == konec)
            {
                if ((smer == Bunka.Right && j == bludiste.GetLength(1)-1)||(smer == Bunka.Down && i == bludiste.GetLength(0)-1))
                {
                    bludiste[i, j].konec = true;
                    bludiste[i, j].Pruchod[pruchod] = true;
                    bludiste[i, j].Pruchod[smer] = true;
                    bludiste[i, j].locked = true;
                    cesta.Push(bludiste[i, j]);
                    return;
                }
            }


            bludiste[i, j].Pruchod[pruchod] = true;
            bludiste[i, j].cesta = true;
            bludiste[i, j].Pruchod[smer] = true;
            bludiste[i, j].locked = true;

            cesta.Push(bludiste[i, j]);


            Point p = Bunka.getNewPosition(i, j, smer);
            i = p.Y;
            j = p.X;


            if (i < bludiste.GetLength(0) && j < bludiste.GetLength(1))
                VybourejCestu(i, j, Bunka.InverzniSmer(smer), konec, rnd);
            else
            {
                if (i >= bludiste.GetLength(0))
                    i--;

                if (j >= bludiste.GetLength(1))
                    j--;


                bludiste[i, j].locked = false;
                bludiste[i, j].konec = true;
                bludiste[i, j].Pruchod[Bunka.Down] = true;
                bludiste[i, j].locked = true;
                return;
            }

        }

        private void generujNovýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerovaniTerenu.Enabled = false;
            GenerujBludiste();
            this.Invalidate();
            GenerovaniTerenu.Enabled = true;
        }

        private void ukončiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hybejse(object sender, KeyEventArgs e)
        {
            if (end)
                return;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (hrac.muzuJitVeSmeru(Bunka.Right))
                    {
                        if (hrac.j+1 < bludiste.GetLength(1))
                            hrac = bludiste[hrac.i, hrac.j + 1];
                    }
                    break;

                case Keys.Left:
                    if (hrac.muzuJitVeSmeru(Bunka.Left))
                    {
                        if (hrac.j - 1 >= 0)
                            hrac = bludiste[hrac.i, hrac.j - 1];
                    }
                    break;

                case Keys.Up:
                    if (hrac.muzuJitVeSmeru(Bunka.Up))
                    {
                        if (hrac.i - 1 >= 0)
                            hrac = bludiste[hrac.i-1, hrac.j];
                    }
                    break;

                case Keys.Down:
                    if (hrac.muzuJitVeSmeru(Bunka.Down))
                    {
                        if (hrac.i + 1 < bludiste.GetLength(0))
                            hrac = bludiste[hrac.i+1, hrac.j];
                    }
                    break;

                default: return;
            }

            if (start == false)
            {
                start = true;
                startTime = DateTime.Now;
            }

            Invalidate();

            if (hrac.konec)
            {
                end = true;
                endTime = DateTime.Now;
                MessageBox.Show("Blahopřeji, vyhrál jste :]", "Hra trvala: " + hraloseMinut + ":" + hraloseSekund);

                Cas.Text = Cas.Text.Remove(Cas.Text.IndexOf(":") + 2);
                Cas.Text += "00:00";
            }

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oprogramu p = new oprogramu();
            p.Show();
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            napoveda n = new napoveda();
            n.Show();
        }

        private void nastaveníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nastaveni n = new nastaveni();
            n.velikostKroku.Value = Convert.ToDecimal((int)((float)(Bunka.krokX + Bunka.krokY) / 2f));
            n.Rozptyl.Value = Convert.ToDecimal(rozptyl);
            n.cmaranice.Checked = cmaranice;
            n.Zpozdeni.Value = Convert.ToDecimal(zdrzeni);
            n.Animovat.Checked = animovatbludiste;

            if (n.ShowDialog() == DialogResult.Yes)
            {
                Bunka.krokX = Convert.ToSingle(n.velikostKroku.Value);
                Bunka.krokY = Convert.ToSingle(n.velikostKroku.Value);

                cmaranice = n.cmaranice.Checked;
                if (cmaranice)
                {
                    rozptyl = Convert.ToInt32(n.Rozptyl.Value);
                }

                animovatbludiste = n.Animovat.Checked;
                if (animovatbludiste)
                {
                    zdrzeni = Convert.ToInt32(n.Zpozdeni.Value);
                }

                GenerujBludiste();
                Invalidate();
            }
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                fullscreen = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                fullscreen = true;
            }
        }
    }


    public class Bunka
    {
        public const int Up = 0;
        public const int Right = 1;
        public const int Down = 2;
        public const int Left = 3;

        public static float krokX = 25;
        public static float krokY = 25;

        public bool cesta = false;
        public bool konec = false;
        public int i = -1;
        public int j = -1;

        public static Point getNewPosition(int i, int j, int smer)
        {
            switch (smer)
            {
                case Bunka.Up: i--;
                    break;

                case Bunka.Down: i++;
                    break;

                case Bunka.Left: j--;
                    break;

                case Bunka.Right: j++;
                    break;
                default: return new Point(-1,-1);
            }

            return new Point(j, i);
        }

        public static bool jsemVBludisti(Point p, Bunka[,] bludiste)
        {
            if (p.X < 0) return false;
            if (p.Y < 0) return false;

            if (p.X >= bludiste.GetLength(1)) return false;
            if (p.Y >= bludiste.GetLength(0)) return false;

            return true;
        }

        public bool[] vratPouzitiSousednichBunek(Bunka[,] bludiste)
        {
            bool[] pouzite = new bool[pruchod.Length];
            for (int t = 0; t < pouzite.Length; t++) pouzite[t] = false;

            for (int smer = 0; smer < pruchod.Length; smer++)
            {
                Point p = Bunka.getNewPosition(i, j, smer);
                if (Bunka.jsemVBludisti(p, bludiste))
                {
                    if (bludiste[p.Y, p.X].jePouzita())
                        pouzite[smer] = true;
                }
            }

            return pouzite;
        }

        public bool muzuJitVeSmeru(int smer)
        {
            if (pruchod[smer])
                return true;

            return false;
        }

        public bool jePouzita()
        {
            bool pouzita = false;
            for (int i = 0; i < pruchod.Length; i++)
            {
                if (pruchod[i])
                    pouzita = true;
            }

            return pouzita;
        }
        public static int InverzniSmer(int smer)
        {
            switch(smer)
            {
                case Up: return Down;
                case Down: return Up;
                case Left: return Right;
                case Right: return Left;
            }

            return -1;
        }

        public Bunka()
        {
            pruchod = new bool[4];
        }

        private bool[] pruchod;
        public bool[] Pruchod
        {
            set
            {
                if (!locked)
                pruchod = value;
            }
            get
            {
                return pruchod;
            }
        }
        public bool locked = false;

    }
}