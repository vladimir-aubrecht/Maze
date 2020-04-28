using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bludiste
{
    public partial class nastaveni : Form
    {
        public nastaveni()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Opravdu si přejete pokračovat? Je nutné přegenerování bludiště.", "Pokračovat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (d == DialogResult.No)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            else if (d == DialogResult.Cancel)
                return;
            
            DialogResult = DialogResult.Yes;
        }

        private void nastavenicmarani(object sender, EventArgs e)
        {
            if (cmaranice.Checked)
            {
                rozptyl_text.Enabled = true;
                Rozptyl.Enabled = true;
            }
            else
            {
                rozptyl_text.Enabled = false;
                Rozptyl.Enabled = false;
            }
        }

        private void nastavenianimace(object sender, EventArgs e)
        {
            if (Animovat.Checked)
            {
                zpozdeni_text.Enabled = true;
                Zpozdeni.Enabled = true;
            }
            else
            {
                zpozdeni_text.Enabled = false;
                Zpozdeni.Enabled = false;
            }
        }
    }
}