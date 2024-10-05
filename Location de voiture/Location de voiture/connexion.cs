using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Location_de_voiture
{
    public partial class connexion : Form
    {
        public connexion()
        {
             try
            {
                InitializeComponent();
                textBox3.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'initialisation de la fenêtre de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connexion_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "data source = DESKTOP-NPD8N33\\SQLEXPRESS;initial catalog=LocationVoitureBD;integrated Security=SSPI";
            cnx.Open();
            String sql = "select * from cnx where nom = '" + textBox2.Text + "' and password = '" + textBox3.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Acceuil acceuil = new Acceuil();
                acceuil.Show();
                this.Hide();
            }
            else
            {
                laberreur.Text = "erreur dans le login ou le password";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}