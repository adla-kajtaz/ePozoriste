namespace ePozoriste.WinUI
{
    partial class frmPrikazGradova
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
            this.cmbDrzave = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvGradovi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostanskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivDrzave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDrzave
            // 
            this.cmbDrzave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrzave.FormattingEnabled = true;
            this.cmbDrzave.Location = new System.Drawing.Point(320, 15);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(209, 28);
            this.cmbDrzave.TabIndex = 13;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(535, 14);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(124, 29);
            this.btnPrikazi.TabIndex = 12;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvGradovi
            // 
            this.dgvGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.PostanskiBroj,
            this.NazivDrzave,
            this.Uredi,
            this.Obrisi});
            this.dgvGradovi.Location = new System.Drawing.Point(19, 60);
            this.dgvGradovi.Name = "dgvGradovi";
            this.dgvGradovi.RowHeadersWidth = 51;
            this.dgvGradovi.RowTemplate.Height = 29;
            this.dgvGradovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradovi.Size = new System.Drawing.Size(762, 376);
            this.dgvGradovi.TabIndex = 11;
            this.dgvGradovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradovi_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "GradId";
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
            // PostanskiBroj
            // 
            this.PostanskiBroj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PostanskiBroj.DataPropertyName = "PostanskiBr";
            this.PostanskiBroj.HeaderText = "Postanski broj";
            this.PostanskiBroj.MinimumWidth = 6;
            this.PostanskiBroj.Name = "PostanskiBroj";
            this.PostanskiBroj.ReadOnly = true;
            this.PostanskiBroj.Width = 119;
            // 
            // NazivDrzave
            // 
            this.NazivDrzave.DataPropertyName = "Drzava";
            this.NazivDrzave.HeaderText = "Naziv drzave";
            this.NazivDrzave.MinimumWidth = 6;
            this.NazivDrzave.Name = "NazivDrzave";
            this.NazivDrzave.Width = 125;
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
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(665, 16);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 29);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(19, 16);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(295, 27);
            this.txtPretraga.TabIndex = 9;
            // 
            // frmPrikazGradova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDrzave);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvGradovi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPrikazGradova";
            this.Text = "Prikaz Gradova";
            this.Load += new System.EventHandler(this.frmPrikazGradova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbDrzave;
        private Button btnPrikazi;
        private DataGridView dgvGradovi;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn PostanskiBroj;
        private DataGridViewTextBoxColumn NazivDrzave;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
    }
}