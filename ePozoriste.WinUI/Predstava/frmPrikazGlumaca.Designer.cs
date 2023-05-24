namespace ePozoriste.WinUI
{
    partial class frmPrikazGlumaca
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
            this.dgvGlumci = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(398, 12);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(124, 29);
            this.btnPrikazi.TabIndex = 11;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvGlumci
            // 
            this.dgvGlumci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlumci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.Uredi,
            this.Obrisi});
            this.dgvGlumci.Location = new System.Drawing.Point(12, 56);
            this.dgvGlumci.Name = "dgvGlumci";
            this.dgvGlumci.RowHeadersWidth = 51;
            this.dgvGlumci.RowTemplate.Height = 29;
            this.dgvGlumci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGlumci.Size = new System.Drawing.Size(632, 376);
            this.dgvGlumci.TabIndex = 10;
            this.dgvGlumci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(528, 10);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 29);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(380, 27);
            this.txtPretraga.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "GlumacId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 53;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 125;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 125;
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
            // frmPrikazGlumaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 440);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvGlumci);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPrikazGlumaca";
            this.Text = "Prikaz glumaca";
            this.Load += new System.EventHandler(this.frmPrikazGlumaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvGlumci;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private Button btnDodaj;
        private TextBox txtPretraga;
    }
}