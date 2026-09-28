using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladatok
{
    public partial class Visszaszamlalas : Form
    {
        private int hatralevo = 0;
     
        private bool valt = true;


        public Visszaszamlalas()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 másodperc
            progressIdo.Minimum = 0;
            progressIdo.Maximum = 30;
            progressIdo.Value = 0;

            btnStop.Enabled = false;
        }

        private void Visszaszamlalas_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hatralevo > 0) hatralevo--;
            progressIdo.Value = hatralevo;
            lblIdo.Text = $"{hatralevo} másodperc van hátra!";
            if (hatralevo == 0)
            {
                timer1.Stop();
                valt = true;
                MessageBox.Show("Lejárt az idő!");
            }
        }

        private void bznIndit_Click(object sender, EventArgs e)
        {
            
            if (valt)
            {
                hatralevo = (int)numIdo.Value;
                progressIdo.Maximum = hatralevo;
                valt = false;
            }

            progressIdo.Value = hatralevo;
            timer1.Start();
            btnStop.Enabled = true;
            bznIndit.Enabled = false;
            numIdo.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStop.Enabled = false;
            bznIndit.Enabled = true;
            numIdo.Enabled = true;

        }

        private void numIdo_ValueChanged(object sender, EventArgs e)
        {
            valt = true;
        }
    }
}
