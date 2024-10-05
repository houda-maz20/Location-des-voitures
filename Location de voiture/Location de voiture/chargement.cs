
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location_de_voiture
{
    public partial class chargement : Form
    {
        private int progressIncrement = 10; 
        private int progressBarMaxValue = 100; 
        private Timer timerChargement; 

        public chargement()
        {
            InitializeComponent();
            InitTimer();
        }
        private void InitTimer()
        {
            timerChargement = new Timer();
            timerChargement.Interval = 1000; 
            timerChargement.Tick += TimerChargement_Tick; 
           
            timerChargement.Start();
        }
        private void TimerChargement_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Increment(progressIncrement);
          
            if (progressBar1.Value >= progressBarMaxValue)
            {

                timerChargement.Stop();
                
                connexion Connexion = new connexion();
                Connexion.Show();

                this.Hide();

            }


        }

        private void chargement_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }


    }
}