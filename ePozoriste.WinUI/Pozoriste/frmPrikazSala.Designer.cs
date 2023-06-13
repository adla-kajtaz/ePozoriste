namespace ePozoriste.WinUI
{
    partial class frmPrikazSala
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
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrRedova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrSjedistaPoRedu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PrikaziTermine = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(515, 12);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(145, 29);
            this.btnPrikazi.TabIndex = 21;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.BrSjedista,
            this.BrRedova,
            this.BrSjedistaPoRedu,
            this.Uredi,
            this.Obrisi,
            this.PrikaziTermine});
            this.dgvSale.Location = new System.Drawing.Point(12, 56);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 29;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(790, 417);
            this.dgvSale.TabIndex = 20;
            this.dgvSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(666, 10);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(136, 29);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(497, 27);
            this.txtPretraga.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "SalaId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 53;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 75;
            // 
            // BrSjedista
            // 
            this.BrSjedista.DataPropertyName = "BrSjedista";
            this.BrSjedista.HeaderText = "Broj sjedista";
            this.BrSjedista.MinimumWidth = 6;
            this.BrSjedista.Name = "BrSjedista";
            this.BrSjedista.Width = 125;
            // 
            // BrRedova
            // 
            this.BrRedova.DataPropertyName = "BrRedova";
            this.BrRedova.HeaderText = "Broj redova";
            this.BrRedova.MinimumWidth = 6;
            this.BrRedova.Name = "BrRedova";
            this.BrRedova.ReadOnly = true;
            this.BrRedova.Width = 125;
            // 
            // BrSjedistaPoRedu
            // 
            this.BrSjedistaPoRedu.DataPropertyName = "BrSjedistaPoRedu";
            this.BrSjedistaPoRedu.HeaderText = "Broj sjedista po redu";
            this.BrSjedistaPoRedu.MinimumWidth = 6;
            this.BrSjedistaPoRedu.Name = "BrSjedistaPoRedu";
            this.BrSjedistaPoRedu.ReadOnly = true;
            this.BrSjedistaPoRedu.Width = 125;
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
            // PrikaziTermine
            // 
            this.PrikaziTermine.HeaderText = "Prikazi termine";
            this.PrikaziTermine.MinimumWidth = 6;
            this.PrikaziTermine.Name = "PrikaziTermine";
            this.PrikaziTermine.ReadOnly = true;
            this.PrikaziTermine.Text = "Prikazi termine";
            this.PrikaziTermine.UseColumnTextForButtonValue = true;
            this.PrikaziTermine.Width = 125;
            // 
            // frmPrikazSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 483);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPrikazSala";
            this.Text = "Prikaz Sala";
            this.Load += new System.EventHandler(this.frmPrikazSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvSale;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn BrSjedista;
        private DataGridViewTextBoxColumn BrRedova;
        private DataGridViewTextBoxColumn BrSjedistaPoRedu;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private DataGridViewButtonColumn PrikaziTermine;
    }
}