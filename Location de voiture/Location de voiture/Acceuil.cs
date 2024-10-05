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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Voituresbt_Click(object sender, EventArgs e)
        {
            Voitures formVoitures = new Voitures();
            formVoitures.Show();
            this.Hide();

        }

        private void clientsbt_Click(object sender, EventArgs e)
        {
            
            Clients formClients = new Clients();
            formClients.Show();
            this.Hide();
        }

        private void locationbt_Click(object sender, EventArgs e)
        {
            
            Locations formLocations = new Locations();
            formLocations.Show();
            this.Hide();
        }

        private void retoursbt_Click(object sender, EventArgs e)
        {
            
            catalogue formcatalogue = new catalogue();
            formcatalogue.Show();
            this.Hide();
        }

        private void dcnxbt_Click(object sender, EventArgs e)
        {

            
            this.Close();

           
            connexion formConnexion = new connexion();
            formConnexion.Show();
        }
    }
 }


        

       
