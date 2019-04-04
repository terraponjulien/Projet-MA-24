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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private DateTime start = DateTime.Now;

        private void cmdStart_Click(object sender, EventArgs e)
        {
            //Lancement du chrono lors du click sur le bouton Start
            timerChrono.Enabled = true;
            timer1.Enabled = true;
        }

        private void timerChrono_Tick(object sender, EventArgs e)
        {
            //Va faire faire cette opération et actualiser le chrono toutes les 1ms
            DateTime now = DateTime.Now;
            TimeSpan time = now - start;
            lblChrono.Text = time+"";
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            //Stop le chrono lors du click sur le bouton Stop
            timerChrono.Enabled = false;
            timer1.Enabled = false;
        }

        double action = 0;
        double minutes = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Va afficher le message mis a jour toutes les 5 secondes
            action=action +5;
            if (action < 60)
            {
                lblTemps.Text = "Vous avez lancé le chrono il y a "+action+ " secondes";
            }
            else
            {
                //Opération permettant de passer en minutes
                minutes=action / 60;
                lblTemps.Text = "Vous avez lancé le chrono il y a " + minutes + " minutes";
            }
        }
    }
}
