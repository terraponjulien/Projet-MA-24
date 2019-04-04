using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MA_24_projet_JulienTerrapon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime start = DateTime.Now;

        private void cmdStart_Click(object sender, EventArgs e)
        {
            //Lancement du chrono lors du click sur le bouton Start
            timerChrono.Enabled = true;
        }

        private void timerChrono_Tick(object sender, EventArgs e)
        {
            //Va faire faire cette opération et actualiser le chrono toutes les 1ms
            DateTime now = DateTime.Now;
            TimeSpan time = now - start;
            lblChrono.Text = time+"";
        }
    }
}
