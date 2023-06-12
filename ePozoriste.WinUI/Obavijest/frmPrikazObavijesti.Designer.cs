namespace ePozoriste.WinUI
{
    partial class frmPrikazObavijesti
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
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Podnaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObavijestKategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(754, 11);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(188, 29);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naslov,
            this.Podnaslov,
            this.DatumKreiranja,
            this.ObavijestKategorija,
            this.Korisnik,
            this.Uredi,
            this.Obrisi});
            this.dgvObavijesti.Location = new System.Drawing.Point(12, 47);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.RowHeadersWidth = 51;
            this.dgvObavijesti.RowTemplate.Height = 29;
            this.dgvObavijesti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijesti.Size = new System.Drawing.Size(1103, 373);
            this.dgvObavijesti.TabIndex = 14;
            this.dgvObavijesti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObavijesti_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(948, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(167, 29);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 11);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(483, 27);
            this.txtPretraga.TabIndex = 12;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(501, 11);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(247, 28);
            this.cmbKategorije.TabIndex = 16;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ObavijestKategorijaId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 53;
            // 
            // Naslov
            // 
            this.Naslov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.MinimumWidth = 6;
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 83;
            // 
            // Podnaslov
            // 
            this.Podnaslov.DataPropertyName = "Podnaslov";
            this.Podnaslov.HeaderText = "Podnaslov";
            this.Podnaslov.MinimumWidth = 6;
            this.Podnaslov.Name = "Podnaslov";
            this.Podnaslov.ReadOnly = true;
            this.Podnaslov.Width = 125;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Datum kreiranja";
            this.DatumKreiranja.MinimumWidth = 6;
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            this.DatumKreiranja.Width = 125;
            // 
            // ObavijestKategorija
            // 
            this.ObavijestKategorija.DataPropertyName = "ObavijestKategorija";
            this.ObavijestKategorija.HeaderText = "Obavijest kategorija";
            this.ObavijestKategorija.MinimumWidth = 6;
            this.ObavijestKategorija.Name = "ObavijestKategorija";
            this.ObavijestKategorija.ReadOnly = true;
            this.ObavijestKategorija.Width = 125;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            this.Korisnik.Width = 125;
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
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // frmPrikazObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 433);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvObavijesti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPrikazObavijesti";
            this.Text = "Prikaz obavijesti";
            this.Load += new System.EventHandler(this.frmPrikazObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvObavijesti;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private ComboBox cmbKategorije;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naslov;
        private DataGridViewTextBoxColumn Podnaslov;
        private DataGridViewTextBoxColumn DatumKreiranja;
        private DataGridViewTextBoxColumn ObavijestKategorija;
        private DataGridViewTextBoxColumn Korisnik;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
    }
}