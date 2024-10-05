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

namespace Location_de_voiture
{
    public partial class Clients : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-NPD8N33\\SQLEXPRESS;Initial Catalog=LocationVoitureBD;Integrated Security=SSPI;";

        public Clients()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private void Clients_Load(object sender, EventArgs e)
        {
            LoadClients();

        }
        private void LoadClients()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                connection.Open();
                string query = "SELECT clid, clnom, cladresse, clphone, clpermis FROM Clients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns["clid"].HeaderText = "ID";
                dataGridView1.Columns["clnom"].HeaderText = "Nom";
                dataGridView1.Columns["cladresse"].HeaderText = "Adresse";
                dataGridView1.Columns["clphone"].HeaderText = "Téléphone";
                dataGridView1.Columns["clpermis"].HeaderText = "Permis de conduire";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients : " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Enregisterbtn_Click(object sender, EventArgs e)
        {
            int  ID = Convert.ToInt32(textBox5.Text);
            string nom = textBox2.Text;
            string adresse = textBox1.Text;
            string telephone = textBox4.Text;
            string permis = textBox3.Text;

            try
            {
                connection.Open();
                string query = "INSERT INTO Clients (clid,clnom, cladresse, clphone, clpermis) VALUES (@ID , @Nom, @Adresse, @Telephone, @Permis)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Adresse", adresse);
                cmd.Parameters.AddWithValue("@Telephone", telephone);
                cmd.Parameters.AddWithValue("@Permis", permis);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client a été ajouté avec succès !");
                LoadClients();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du client : " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void Modifierbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["clid"].Value);
                string nom = textBox2.Text;
                string adresse = textBox1.Text;
                string telephone = textBox4.Text;
                string permis = textBox3.Text;

                try
                {
                    connection.Open();
                    string query = "UPDATE Clients SET clnom = @Nom, cladresse = @Adresse, clphone = @Telephone, clpermis = @Permis WHERE clid = @ClientID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Adresse", adresse);
                    cmd.Parameters.AddWithValue("@Telephone", telephone);
                    cmd.Parameters.AddWithValue("@Permis", permis);
                    cmd.Parameters.AddWithValue("@ClientID", clientId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le client a été modifié avec succès !");
                    LoadClients();
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification du client : " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.");
            }

        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["clid"].Value);

                try
                {
                    connection.Open();
                    string query = "DELETE FROM Clients WHERE clid = @ClientID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ClientID", clientId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le client a été supprimé avec succès !");
                    LoadClients();
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du client : " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
            }
        }
        private void ClearTextBoxes()
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void acceuilbtn_Click(object sender, EventArgs e)
        {
            Acceuil acceuilForm = new Acceuil();
            acceuilForm.Show();
            this.Close();
        }
    }
}
