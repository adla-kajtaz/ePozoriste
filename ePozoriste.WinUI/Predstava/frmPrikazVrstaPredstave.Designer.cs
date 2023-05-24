namespace ePozoriste.WinUI
{
    partial class frmPrikazVrstaPredstave
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
            this.dgvVrstePredstave = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePredstave)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(398, 12);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(124, 29);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvVrstePredstave
            // 
            this.dgvVrstePredstave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstePredstave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Uredi,
            this.Obrisi});
            this.dgvVrstePredstave.Location = new System.Drawing.Point(12, 56);
            this.dgvVrstePredstave.Name = "dgvVrstePredstave";
            this.dgvVrstePredstave.RowHeadersWidth = 51;
            this.dgvVrstePredstave.RowTemplate.Height = 29;
            this.dgvVrstePredstave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVrstePredstave.Size = new System.Drawing.Size(632, 339);
            this.dgvVrstePredstave.TabIndex = 14;
            this.dgvVrstePredstave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVrstePredstave_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "VrstaPredstaveId";
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
            this.btnDodaj.Location = new System.Drawing.Point(528, 10);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 29);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(380, 27);
            this.txtPretraga.TabIndex = 12;
            // 
            // frmPrikazVrstaPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 405);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvVrstePredstave);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPrikazVrstaPredstave";
            this.Text = "Prikaz vrsta predstave";
            this.Load += new System.EventHandler(this.frmPrikazVrstaPredstave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePredstave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvVrstePredstave;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private Button btnDodaj;
        private TextBox txtPretraga;
    }
}