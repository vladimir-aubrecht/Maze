using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bludiste
{
    public partial class nastavenivelikosti : Form
    {

        public int originalniSirka = 0;
        public int originalniVyska = 0;

        public nastavenivelikosti()
        {
            InitializeComponent();
        }

        private void okb_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelb_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void zmenakroku(object sender, EventArgs e)
        {
            int krok = Convert.ToInt32(this.krok.Value);

            int sirka = originalniSirka / (int)krok;
            int vyska = originalniVyska / (int)krok;

            radky.Maximum = Convert.ToDecimal(vyska);
            sloupce.Maximum = Convert.ToDecimal(sirka);

            radky.Value = Convert.ToDecimal(vyska);
            sloupce.Value = Convert.ToDecimal(sirka);
        }
    }
}