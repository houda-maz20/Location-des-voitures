namespace Location_de_voiture
{
    partial class Voitures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voitures));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numplaquetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.marquecb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modeletb = new System.Windows.Forms.TextBox();
            this.statuscb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prixjournaliertb = new System.Windows.Forms.TextBox();
            this.modifierbt = new System.Windows.Forms.Button();
            this.enregistrerbt = new System.Windows.Forms.Button();
            this.supprimerbt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new Location_de_voiture.LocationVoitureBDDataSet1TableAdapters.TableAdapterManager();
            this.acceuilbtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridvoiture = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridvoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(343, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestion des Voitures";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 22);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(21, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numéro du Plaque";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numplaquetb
            // 
            this.numplaquetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numplaquetb.Location = new System.Drawing.Point(16, 179);
            this.numplaquetb.Name = "numplaquetb";
            this.numplaquetb.Size = new System.Drawing.Size(163, 24);
            this.numplaquetb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(241, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marque";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // marquecb
            // 
            this.marquecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.marquecb.FormattingEnabled = true;
            this.marquecb.Items.AddRange(new object[] {
            "Toyota ",
            "Dacia",
            "Opel",
            "Audi",
            "Seat",
            "Nissan",
            "Peugeot",
            "Mercedes",
            "autres"});
            this.marquecb.Location = new System.Drawing.Point(213, 179);
            this.marquecb.Name = "marquecb";
            this.marquecb.Size = new System.Drawing.Size(121, 26);
            this.marquecb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(426, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Modele";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modeletb
            // 
            this.modeletb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.modeletb.Location = new System.Drawing.Point(373, 183);
            this.modeletb.Name = "modeletb";
            this.modeletb.Size = new System.Drawing.Size(163, 24);
            this.modeletb.TabIndex = 14;
            // 
            // statuscb
            // 
            this.statuscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.statuscb.FormattingEnabled = true;
            this.statuscb.Items.AddRange(new object[] {
            "Prise ",
            "Disponible"});
            this.statuscb.Location = new System.Drawing.Point(574, 179);
            this.statuscb.Name = "statuscb";
            this.statuscb.Size = new System.Drawing.Size(121, 26);
            this.statuscb.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(604, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(730, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Prix journalier en DH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prixjournaliertb
            // 
            this.prixjournaliertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.prixjournaliertb.Location = new System.Drawing.Point(734, 181);
            this.prixjournaliertb.Name = "prixjournaliertb";
            this.prixjournaliertb.Size = new System.Drawing.Size(163, 24);
            this.prixjournaliertb.TabIndex = 18;
            this.prixjournaliertb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // modifierbt
            // 
            this.modifierbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.modifierbt.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifierbt.Location = new System.Drawing.Point(177, 238);
            this.modifierbt.Name = "modifierbt";
            this.modifierbt.Size = new System.Drawing.Size(129, 35);
            this.modifierbt.TabIndex = 20;
            this.modifierbt.Text = "Modifier";
            this.modifierbt.UseVisualStyleBackColor = false;
            this.modifierbt.Click += new System.EventHandler(this.modifierbt_Click);
            // 
            // enregistrerbt
            // 
            this.enregistrerbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.enregistrerbt.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enregistrerbt.Location = new System.Drawing.Point(388, 238);
            this.enregistrerbt.Name = "enregistrerbt";
            this.enregistrerbt.Size = new System.Drawing.Size(129, 35);
            this.enregistrerbt.TabIndex = 21;
            this.enregistrerbt.Text = "Enregistrer";
            this.enregistrerbt.UseVisualStyleBackColor = false;
            this.enregistrerbt.Click += new System.EventHandler(this.enregistrerbt_Click);
            // 
            // supprimerbt
            // 
            this.supprimerbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.supprimerbt.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimerbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerbt.Location = new System.Drawing.Point(608, 238);
            this.supprimerbt.Name = "supprimerbt";
            this.supprimerbt.Size = new System.Drawing.Size(129, 35);
            this.supprimerbt.TabIndex = 22;
            this.supprimerbt.Text = "Supprimer";
            this.supprimerbt.UseVisualStyleBackColor = false;
            this.supprimerbt.Click += new System.EventHandler(this.supprimerbt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(384, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Liste Des Voitutres";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientsTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.LocationTableAdapter = null;
            this.tableAdapterManager1.retourTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Location_de_voiture.LocationVoitureBDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VoitureTableAdapter = null;
            // 
            // acceuilbtn
            // 
            this.acceuilbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.acceuilbtn.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceuilbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acceuilbtn.Location = new System.Drawing.Point(833, 570);
            this.acceuilbtn.Name = "acceuilbtn";
            this.acceuilbtn.Size = new System.Drawing.Size(129, 35);
            this.acceuilbtn.TabIndex = 27;
            this.acceuilbtn.Text = "Acceuil";
            this.acceuilbtn.UseVisualStyleBackColor = false;
            this.acceuilbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(800, 570);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(829, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 66;
            this.button1.Text = "Catalogue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridvoiture
            // 
            this.dataGridvoiture.AllowUserToAddRows = false;
            this.dataGridvoiture.AllowUserToDeleteRows = false;
            this.dataGridvoiture.AllowUserToOrderColumns = true;
            this.dataGridvoiture.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridvoiture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridvoiture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridvoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridvoiture.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridvoiture.Location = new System.Drawing.Point(113, 356);
            this.dataGridvoiture.Name = "dataGridvoiture";
            this.dataGridvoiture.Size = new System.Drawing.Size(710, 187);
            this.dataGridvoiture.TabIndex = 40;
            this.dataGridvoiture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Voitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(974, 632);
            this.Controls.Add(this.dataGridvoiture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.acceuilbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.supprimerbt);
            this.Controls.Add(this.enregistrerbt);
            this.Controls.Add(this.modifierbt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prixjournaliertb);
            this.Controls.Add(this.statuscb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modeletb);
            this.Controls.Add(this.marquecb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numplaquetb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Voitures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voitures";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Voitures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridvoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numplaquetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox marquecb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modeletb;
        private System.Windows.Forms.ComboBox statuscb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prixjournaliertb;
        private System.Windows.Forms.Button modifierbt;
        private System.Windows.Forms.Button enregistrerbt;
        private System.Windows.Forms.Button supprimerbt;
        private System.Windows.Forms.Label label7;
        private LocationVoitureBDDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button acceuilbtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridvoiture;
    }
}