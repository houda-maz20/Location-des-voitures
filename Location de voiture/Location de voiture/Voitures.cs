using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location_de_voiture
{
    public partial class Voitures : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-NPD8N33\\SQLEXPRESS;Initial Catalog=LocationVoitureBD;Integrated Security=SSPI;";
        public Voitures()
      
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }


        private void Voitures_Load(object sender, EventArgs e)
        {
            LoadVoitures();
        }
        private void LoadVoitures()
        {
                try
                {
                       if (connection.State == ConnectionState.Open)
                            connection.Close();
                
                        connection.Open();

                    
                    string query = "SELECT * FROM Voiture";

                   
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    
                    DataTable table = new DataTable();

                    
                    adapter.Fill(table);

                
                dataGridvoiture.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des voitures : " + ex.Message);
                }
                finally
                {
                    
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }

            
          

        }
      
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewVoitures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void enregistrerbt_Click(object sender, EventArgs e)
        {
            try
            {
                
                connection.Open();

                string numPlaque = numplaquetb.Text;
                string marque = marquecb.SelectedItem.ToString();
                string modele = modeletb.Text;
                string statut = statuscb.SelectedItem.ToString();
                int prix = Convert.ToInt32(prixjournaliertb.Text);

                
                if (string.IsNullOrWhiteSpace(numPlaque) || string.IsNullOrWhiteSpace(marque) || string.IsNullOrWhiteSpace(modele) || string.IsNullOrWhiteSpace(statut))
                {
                    MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                string query = "INSERT INTO Voiture (NumPlaque, Marque, Modele, Statut, Prix) VALUES (@NumPlaque, @Marque, @Modele, @Statut, @Prix)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NumPlaque", numPlaque);
                cmd.Parameters.AddWithValue("@Marque", marque);
                cmd.Parameters.AddWithValue("@Modele", modele);
                cmd.Parameters.AddWithValue("@Statut", statut);
                cmd.Parameters.AddWithValue("@Prix", prix);
                cmd.ExecuteNonQuery();

                MessageBox.Show("La voiture a été ajoutée avec succès !");
                LoadVoitures(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la voiture : " + ex.Message);
            }
            finally
            {
                
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        

    }


        private void voitureBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void modifierbt_Click(object sender, EventArgs e)
        {
            
            if (dataGridvoiture.SelectedRows.Count > 0)
            {
               
                string numPlaque = dataGridvoiture.SelectedRows[0].Cells["NumPlaque"].Value.ToString();

                try
                {
                    
                    connection.Open();

                    
                    string marque = marquecb.SelectedItem?.ToString();
                    string modele = modeletb.Text;
                    string statut = statuscb.SelectedItem.ToString();
                    int prix = Convert.ToInt32(prixjournaliertb.Text);


                   
                    if (string.IsNullOrWhiteSpace(numPlaque) || string.IsNullOrWhiteSpace(marque) || string.IsNullOrWhiteSpace(modele) || string.IsNullOrWhiteSpace(statut))
                    {
                        MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                   
                    string query = "UPDATE Voiture SET NumPlaque = @NumPlaque, Marque = @Marque, Modele = @Modele, Statut = @Statut, Prix = @Prix WHERE NumPlaque = @NumPlaque";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Marque", marque);
                    cmd.Parameters.AddWithValue("@Modele", modele);
                    cmd.Parameters.AddWithValue("@Statut", statut);
                    cmd.Parameters.AddWithValue("@Prix", prix);
                    cmd.Parameters.AddWithValue("@NumPlaque", numPlaque);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("La voiture a été modifiée avec succès !");
                    LoadVoitures(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de la voiture : " + ex.Message);
                }
                finally
                {
                   
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une voiture à modifier.");
            }

        }
        private void supprimerbt_Click(object sender, EventArgs e)
        {
          
            if (dataGridvoiture.SelectedRows.Count > 0)
            {
                
                string numPlaque = dataGridvoiture.SelectedRows[0].Cells["NumPlaque"].Value.ToString();

                try
                {
                    
                    connection.Open();

                    
                    string query = "DELETE FROM Voiture WHERE NumPlaque = @NumPlaque";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@NumPlaque", numPlaque);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("La voiture a été supprimée avec succès !");
                    LoadVoitures(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression de la voiture : " + ex.Message);
                }
                finally
                {
                   
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une voiture à supprimer.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acceuil acceuilForm = new Acceuil();
            acceuilForm.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            catalogue catalogueForm = new catalogue();
            catalogueForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



    
}







