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
    public partial class catalogue : Form
    {
        private int imageNumber = 1;
        private Timer timer;
        public catalogue()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 2000; // Intervalle de 2 secondes
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        private void LoadNextImage()
        {
            if (imageNumber > 10)
            {
                imageNumber = 1;
            }

            string imagePath = string.Format(@"Images\{0}.jpg", imageNumber);
            slidePic.ImageLocation = imagePath;
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void catalogue_Load(object sender, EventArgs e)
        {
            
            LoadNextImage();
        }

        private void acceuilbtn_Click(object sender, EventArgs e)
        {
            Acceuil acceuilForm = new Acceuil();
            acceuilForm.Show();
            this.Close();
        }
    }
}
