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
    public partial class Locations : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-NPD8N33\\SQLEXPRESS;Initial Catalog=LocationVoitureBD;Integrated Security=SSPI;";

        public Locations()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private void Locations_Load(object sender, EventArgs e)
        {
            UpdateCarStatus();
            LoadVoitures();
            LoadClients();
            LoadLocations();
           
        }
        private void UpdateCarStatus()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string queryUpdateVoiture = @"
                    UPDATE Voiture 
                    SET Statut = 'Disponible'
                    WHERE NumPlaque IN (
                        SELECT voiture
                        FROM Location
                        WHERE dateretour < GETDATE()
                    )";

                SqlCommand cmdUpdateVoiture = new SqlCommand(queryUpdateVoiture, connection);
                cmdUpdateVoiture.ExecuteNonQuery();
                string queryUpdateLocation = @"
                    UPDATE Location
                    SET statut = 'Terminé'
                    WHERE dateretour < GETDATE() AND statut = 'Louée'";
                SqlCommand cmdUpdateLocation = new SqlCommand(queryUpdateLocation, connection);
                cmdUpdateLocation.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour du statut des voitures : " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void LoadVoitures()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = "SELECT NumPlaque, Marque, Prix, Statut FROM Voiture";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                voitureComboBox.DataSource = table;
                voitureComboBox.DisplayMember = "Marque";
                voitureComboBox.ValueMember = "NumPlaque";
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
        private void LoadClients()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

               
                string query = "SELECT clid, clnom FROM Clients";

                
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

             
                ClientComboBox.DataSource = table;
                ClientComboBox.DisplayMember = "clnom"; 
                ClientComboBox.ValueMember = "clid"; 
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
        private void LoadLocations()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();
                string query = "SELECT loID, voiture, client, datelocation, dateretour, cout, statut FROM Location";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des locations : " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private bool IsCarAvailable(string voiture, DateTime startDate, DateTime endDate)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = @"
                    SELECT COUNT(*) 
                    FROM Location 
                    WHERE voiture = @Voiture
                    AND (
                        (@StartDate < dateretour AND @EndDate > datelocation)
                    )";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Voiture", voiture);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification de la disponibilité de la voiture : " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadVoitures();

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadVoitures();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                DateTime dateDebut = dateTimePicker1.Value;
                DateTime dateFin = dateTimePicker2.Value;
                string voiture = voitureComboBox.SelectedValue.ToString().Trim(); ;
                int client = Convert.ToInt32(ClientComboBox.SelectedValue.ToString());
                int ID = Convert.ToInt32(textBox1.Text);

                if (!IsCarAvailable(voiture, dateDebut, dateFin))
                {
                    MessageBox.Show("La voiture sélectionnée est déjà réservée pour les dates spécifiées.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string getPrixQuery = "SELECT Prix FROM Voiture WHERE NumPlaque = @NumPlaque";
                SqlCommand getPrixCmd = new SqlCommand(getPrixQuery, connection);
                getPrixCmd.Parameters.AddWithValue("@NumPlaque", voiture);
                decimal prixParJour = Convert.ToDecimal(getPrixCmd.ExecuteScalar());
                int nombreDeJours = (dateFin - dateDebut).Days;
                decimal cout = prixParJour * nombreDeJours;

                
                string query = "INSERT INTO Location (loID, voiture, client, datelocation, dateretour, cout, statut) VALUES (@ID, @Voiture, @Client, @DateLocation, @DateRetour, @Cout, @Statut)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Voiture", voiture);
                cmd.Parameters.AddWithValue("@Client", client);
                cmd.Parameters.AddWithValue("@DateLocation", dateDebut);
                cmd.Parameters.AddWithValue("@DateRetour", dateFin);
                cmd.Parameters.AddWithValue("@Cout", cout); 
                cmd.Parameters.AddWithValue("@Statut", "Louée"); 
                cmd.ExecuteNonQuery();

               
                string updateVoitureQuery = "UPDATE Voiture SET Statut = 'prise' WHERE NumPlaque = @NumPlaque";
                SqlCommand updateVoitureCmd = new SqlCommand(updateVoitureQuery, connection);
                updateVoitureCmd.Parameters.AddWithValue("@NumPlaque", voiture);
                updateVoitureCmd.ExecuteNonQuery();

                MessageBox.Show("La location a été enregistrée avec succès !");
                LoadLocations();
                UpdateCarStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la location : " + ex.Message);
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
                
                int locationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["loID"].Value);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    
                    DateTime dateDebut = dateTimePicker1.Value;
                    DateTime dateFin = dateTimePicker2.Value;
                    string voiture = voitureComboBox.SelectedValue.ToString();
                    int client = Convert.ToInt32(ClientComboBox.SelectedValue.ToString());

                    
                    string query = "UPDATE Location SET voiture = @Voiture, client = @Client, datelocation = @DateLocation, dateretour = @DateRetour WHERE loID = @LocationID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Voiture", voiture);
                    cmd.Parameters.AddWithValue("@Client", client);
                    cmd.Parameters.AddWithValue("@DateLocation", dateDebut);
                    cmd.Parameters.AddWithValue("@DateRetour", dateFin);
                    cmd.Parameters.AddWithValue("@LocationID", locationId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("La location a été modifiée avec succès !");
                   
                    LoadLocations();
                    UpdateCarStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de la location : " + ex.Message);
                }
                finally
                {
                    
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une location à modifier.");
            }

        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                int locationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["loID"].Value);

                try
                {
                    if (connection.State == ConnectionState.Closed)

                        connection.Open();

                    string query = "DELETE FROM Location WHERE loID = @LocationID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@LocationID", locationId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("La location a été supprimée avec succès !");
                   
                    LoadLocations();
                    UpdateCarStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression de la location : " + ex.Message);
                }
                finally
                {
                    
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une location à supprimer.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void acceuilbtn_Click(object sender, EventArgs e)
        {
            Acceuil acceuilForm = new Acceuil();
            acceuilForm.Show(); 
            this.Close(); 
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}