namespace ePozoriste.WinUI
{
    partial class frmPrikazPredstava
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
            this.dgvPredstave = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeTrajanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DodajGlumca = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DodajVrstuPredstave = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstave)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(443, 12);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(164, 29);
            this.btnPrikazi.TabIndex = 11;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvPredstave
            // 
            this.dgvPredstave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredstave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.VrijemeTrajanja,
            this.Uredi,
            this.Obrisi,
            this.DodajGlumca,
            this.DodajVrstuPredstave});
            this.dgvPredstave.Location = new System.Drawing.Point(12, 56);
            this.dgvPredstave.Name = "dgvPredstave";
            this.dgvPredstave.RowHeadersWidth = 51;
            this.dgvPredstave.RowTemplate.Height = 29;
            this.dgvPredstave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstave.Size = new System.Drawing.Size(760, 388);
            this.dgvPredstave.TabIndex = 10;
            this.dgvPredstave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredstave_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(613, 10);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(159, 29);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(425, 27);
            this.txtPretraga.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "PredstavaId";
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
            // VrijemeTrajanja
            // 
            this.VrijemeTrajanja.DataPropertyName = "VrijemeTrajanje";
            this.VrijemeTrajanja.HeaderText = "Vrijeme trajanja";
            this.VrijemeTrajanja.MinimumWidth = 6;
            this.VrijemeTrajanja.Name = "VrijemeTrajanja";
            this.VrijemeTrajanja.ReadOnly = true;
            this.VrijemeTrajanja.Width = 125;
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
            // DodajGlumca
            // 
            this.DodajGlumca.HeaderText = "Dodaj glumca";
            this.DodajGlumca.MinimumWidth = 6;
            this.DodajGlumca.Name = "DodajGlumca";
            this.DodajGlumca.Text = "Dodaj glumca";
            this.DodajGlumca.UseColumnTextForButtonValue = true;
            this.DodajGlumca.Width = 125;
            // 
            // DodajVrstuPredstave
            // 
            this.DodajVrstuPredstave.HeaderText = "Dodaj vrstu predstave";
            this.DodajVrstuPredstave.MinimumWidth = 6;
            this.DodajVrstuPredstave.Name = "DodajVrstuPredstave";
            this.DodajVrstuPredstave.Text = "Dodaj vrstu predstave";
            this.DodajVrstuPredstave.UseColumnTextForButtonValue = true;
            this.DodajVrstuPredstave.Width = 125;
            // 
            // frmPrikazPredstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 455);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvPredstave);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPrikazPredstava";
            this.Text = "Prikaz predstava";
            this.Load += new System.EventHandler(this.frmPrikazPredstava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvPredstave;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn VrijemeTrajanja;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private DataGridViewButtonColumn DodajGlumca;
        private DataGridViewButtonColumn DodajVrstuPredstave;
    }
}