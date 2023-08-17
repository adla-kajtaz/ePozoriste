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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpDatumIzvodjenja = new System.Windows.Forms.DateTimePicker();
            this.cmbPredstave = new System.Windows.Forms.ComboBox();
            this.cbPremijera = new System.Windows.Forms.CheckBox();
            this.cbPredpremijera = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Predstava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzvodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premijera = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Predpremijera = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Karte = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(1020, 46);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(138, 29);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predstava,
            this.Sala,
            this.DatumIzvodjenja,
            this.VrijemeOdrzavanja,
            this.CijenaKarte,
            this.Premijera,
            this.Predpremijera,
            this.Karte,
            this.Uredi,
            this.Obrisi});
            this.dgvTermini.Location = new System.Drawing.Point(6, 26);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 29;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(1309, 520);
            this.dgvTermini.TabIndex = 14;
            this.dgvTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1164, 46);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(151, 29);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Novi termin";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dtpDatumIzvodjenja
            // 
            this.dtpDatumIzvodjenja.Location = new System.Drawing.Point(6, 45);
            this.dtpDatumIzvodjenja.Name = "dtpDatumIzvodjenja";
            this.dtpDatumIzvodjenja.Size = new System.Drawing.Size(305, 27);
            this.dtpDatumIzvodjenja.TabIndex = 16;
            // 
            // cmbPredstave
            // 
            this.cmbPredstave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredstave.FormattingEnabled = true;
            this.cmbPredstave.Location = new System.Drawing.Point(330, 44);
            this.cmbPredstave.Name = "cmbPredstave";
            this.cmbPredstave.Size = new System.Drawing.Size(285, 28);
            this.cmbPredstave.TabIndex = 17;
            // 
            // cbPremijera
            // 
            this.cbPremijera.AutoSize = true;
            this.cbPremijera.Location = new System.Drawing.Point(684, 46);
            this.cbPremijera.Name = "cbPremijera";
            this.cbPremijera.Size = new System.Drawing.Size(94, 24);
            this.cbPremijera.TabIndex = 19;
            this.cbPremijera.Text = "Premijera";
            this.cbPremijera.UseVisualStyleBackColor = true;
            // 
            // cbPredpremijera
            // 
            this.cbPredpremijera.AutoSize = true;
            this.cbPredpremijera.Location = new System.Drawing.Point(784, 46);
            this.cbPredpremijera.Name = "cbPredpremijera";
            this.cbPredpremijera.Size = new System.Drawing.Size(125, 24);
            this.cbPredpremijera.TabIndex = 20;
            this.cbPredpremijera.Text = "Predpremijera";
            this.cbPredpremijera.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.cbPredpremijera);
            this.groupBox1.Controls.Add(this.dtpDatumIzvodjenja);
            this.groupBox1.Controls.Add(this.cbPremijera);
            this.groupBox1.Controls.Add(this.cmbPredstave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1334, 106);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga termina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Predstava:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTermini);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 576);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termini";
            // 
            // Predstava
            // 
            this.Predstava.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predstava.DataPropertyName = "Predstava";
            this.Predstava.HeaderText = "Predstava";
            this.Predstava.MinimumWidth = 6;
            this.Predstava.Name = "Predstava";
            this.Predstava.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.MinimumWidth = 6;
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // DatumIzvodjenja
            // 
            this.DatumIzvodjenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIzvodjenja.DataPropertyName = "DatumOdrzavanja";
            this.DatumIzvodjenja.HeaderText = "Datum izvođenja";
            this.DatumIzvodjenja.MinimumWidth = 6;
            this.DatumIzvodjenja.Name = "DatumIzvodjenja";
            this.DatumIzvodjenja.ReadOnly = true;
            // 
            // VrijemeOdrzavanja
            // 
            this.VrijemeOdrzavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VrijemeOdrzavanja.DataPropertyName = "VrijemeOdrzavanja";
            this.VrijemeOdrzavanja.HeaderText = "Vrijeme održavanja";
            this.VrijemeOdrzavanja.MinimumWidth = 6;
            this.VrijemeOdrzavanja.Name = "VrijemeOdrzavanja";
            this.VrijemeOdrzavanja.ReadOnly = true;
            // 
            // CijenaKarte
            // 
            this.CijenaKarte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CijenaKarte.DataPropertyName = "CijenaKarte";
            this.CijenaKarte.HeaderText = "Cijena karte";
            this.CijenaKarte.MinimumWidth = 6;
            this.CijenaKarte.Name = "CijenaKarte";
            this.CijenaKarte.ReadOnly = true;
            // 
            // Premijera
            // 
            this.Premijera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Premijera.DataPropertyName = "Premijera";
            this.Premijera.HeaderText = "Premijera";
            this.Premijera.MinimumWidth = 6;
            this.Premijera.Name = "Premijera";
            this.Premijera.ReadOnly = true;
            this.Premijera.Width = 78;
            // 
            // Predpremijera
            // 
            this.Predpremijera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predpremijera.DataPropertyName = "Predpremijera";
            this.Predpremijera.HeaderText = "Predpremijera";
            this.Predpremijera.MinimumWidth = 6;
            this.Predpremijera.Name = "Predpremijera";
            this.Predpremijera.ReadOnly = true;
            // 
            // Karte
            // 
            this.Karte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Karte.HeaderText = "Karte";
            this.Karte.MinimumWidth = 6;
            this.Karte.Name = "Karte";
            this.Karte.ReadOnly = true;
            this.Karte.Text = "Karte";
            this.Karte.UseColumnTextForButtonValue = true;
            // 
            // Uredi
            // 
            this.Uredi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            // 
            // Obrisi
            // 
            this.Obrisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // frmPrikazTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazTermina";
            this.Text = "Prikaz termina";
            this.Load += new System.EventHandler(this.frmPrikazTermina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvTermini;
        private Button btnDodaj;
        private DateTimePicker dtpDatumIzvodjenja;
        private ComboBox cmbPredstave;
        private CheckBox cbPremijera;
        private CheckBox cbPredpremijera;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Predstava;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn DatumIzvodjenja;
        private DataGridViewTextBoxColumn VrijemeOdrzavanja;
        private DataGridViewTextBoxColumn CijenaKarte;
        private DataGridViewCheckBoxColumn Premijera;
        private DataGridViewCheckBoxColumn Predpremijera;
        private DataGridViewButtonColumn Karte;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
    }
}