namespace ePozoriste.WinUI
{
    partial class frmPrikazTermina
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predstava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzvodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premijera = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Predpremijera = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Karte = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpDatumIzvodjenja = new System.Windows.Forms.DateTimePicker();
            this.cmbPredstave = new System.Windows.Forms.ComboBox();
            this.cbPremijera = new System.Windows.Forms.CheckBox();
            this.cbPredpremijera = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(939, 10);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(206, 29);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Predstava,
            this.Sala,
            this.DatumIzvodjenja,
            this.CijenaKarte,
            this.Premijera,
            this.Predpremijera,
            this.Karte,
            this.Uredi,
            this.Obrisi});
            this.dgvTermini.Location = new System.Drawing.Point(22, 45);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 29;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(1309, 424);
            this.dgvTermini.TabIndex = 14;
            this.dgvTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TerminId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Predstava
            // 
            this.Predstava.DataPropertyName = "Predstava";
            this.Predstava.HeaderText = "Predstava";
            this.Predstava.MinimumWidth = 6;
            this.Predstava.Name = "Predstava";
            this.Predstava.ReadOnly = true;
            this.Predstava.Width = 125;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.MinimumWidth = 6;
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            this.Sala.Width = 125;
            // 
            // DatumIzvodjenja
            // 
            this.DatumIzvodjenja.DataPropertyName = "DatumVrijemeOdrzavanja";
            this.DatumIzvodjenja.HeaderText = "Datum izvođenja";
            this.DatumIzvodjenja.MinimumWidth = 6;
            this.DatumIzvodjenja.Name = "DatumIzvodjenja";
            this.DatumIzvodjenja.ReadOnly = true;
            this.DatumIzvodjenja.Width = 125;
            // 
            // CijenaKarte
            // 
            this.CijenaKarte.DataPropertyName = "CijenaKarte";
            this.CijenaKarte.HeaderText = "Cijena karte";
            this.CijenaKarte.MinimumWidth = 6;
            this.CijenaKarte.Name = "CijenaKarte";
            this.CijenaKarte.ReadOnly = true;
            this.CijenaKarte.Width = 125;
            // 
            // Premijera
            // 
            this.Premijera.DataPropertyName = "Premijera";
            this.Premijera.HeaderText = "Premijera";
            this.Premijera.MinimumWidth = 6;
            this.Premijera.Name = "Premijera";
            this.Premijera.ReadOnly = true;
            this.Premijera.Width = 125;
            // 
            // Predpremijera
            // 
            this.Predpremijera.DataPropertyName = "Predpremijera";
            this.Predpremijera.HeaderText = "Predpremijera";
            this.Predpremijera.MinimumWidth = 6;
            this.Predpremijera.Name = "Predpremijera";
            this.Predpremijera.ReadOnly = true;
            this.Predpremijera.Width = 125;
            // 
            // Karte
            // 
            this.Karte.HeaderText = "Karte";
            this.Karte.MinimumWidth = 6;
            this.Karte.Name = "Karte";
            this.Karte.ReadOnly = true;
            this.Karte.Text = "Karte";
            this.Karte.UseColumnTextForButtonValue = true;
            this.Karte.Width = 125;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            this.Uredi.Width = 125;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1151, 10);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(180, 29);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dtpDatumIzvodjenja
            // 
            this.dtpDatumIzvodjenja.Location = new System.Drawing.Point(22, 12);
            this.dtpDatumIzvodjenja.Name = "dtpDatumIzvodjenja";
            this.dtpDatumIzvodjenja.Size = new System.Drawing.Size(305, 27);
            this.dtpDatumIzvodjenja.TabIndex = 16;
            // 
            // cmbPredstave
            // 
            this.cmbPredstave.FormattingEnabled = true;
            this.cmbPredstave.Location = new System.Drawing.Point(333, 10);
            this.cmbPredstave.Name = "cmbPredstave";
            this.cmbPredstave.Size = new System.Drawing.Size(369, 28);
            this.cmbPredstave.TabIndex = 17;
            // 
            // cbPremijera
            // 
            this.cbPremijera.AutoSize = true;
            this.cbPremijera.Location = new System.Drawing.Point(708, 12);
            this.cbPremijera.Name = "cbPremijera";
            this.cbPremijera.Size = new System.Drawing.Size(94, 24);
            this.cbPremijera.TabIndex = 19;
            this.cbPremijera.Text = "Premijera";
            this.cbPremijera.UseVisualStyleBackColor = true;
            // 
            // cbPredpremijera
            // 
            this.cbPredpremijera.AutoSize = true;
            this.cbPredpremijera.Location = new System.Drawing.Point(808, 12);
            this.cbPredpremijera.Name = "cbPredpremijera";
            this.cbPredpremijera.Size = new System.Drawing.Size(125, 24);
            this.cbPredpremijera.TabIndex = 20;
            this.cbPredpremijera.Text = "Predpremijera";
            this.cbPredpremijera.UseVisualStyleBackColor = true;
            // 
            // frmPrikazTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 494);
            this.Controls.Add(this.cbPredpremijera);
            this.Controls.Add(this.cbPremijera);
            this.Controls.Add(this.cmbPredstave);
            this.Controls.Add(this.dtpDatumIzvodjenja);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmPrikazTermina";
            this.Text = "Prikaz termina";
            this.Load += new System.EventHandler(this.frmPrikazTermina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvTermini;
        private Button btnDodaj;
        private DateTimePicker dtpDatumIzvodjenja;
        private ComboBox cmbPredstave;
        private CheckBox cbPremijera;
        private CheckBox cbPredpremijera;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Predstava;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn DatumIzvodjenja;
        private DataGridViewTextBoxColumn CijenaKarte;
        private DataGridViewCheckBoxColumn Premijera;
        private DataGridViewCheckBoxColumn Predpremijera;
        private DataGridViewButtonColumn Karte;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
    }
}