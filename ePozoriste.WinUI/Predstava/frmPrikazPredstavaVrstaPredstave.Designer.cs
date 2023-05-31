namespace ePozoriste.WinUI
{
    partial class frmPrikazPredstavaVrstaPredstave
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
            this.dgvVrstePredstave = new System.Windows.Forms.DataGridView();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.VrstaPredstave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePredstave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVrstePredstave
            // 
            this.dgvVrstePredstave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstePredstave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaPredstave,
            this.Obrisi});
            this.dgvVrstePredstave.Location = new System.Drawing.Point(12, 65);
            this.dgvVrstePredstave.Name = "dgvVrstePredstave";
            this.dgvVrstePredstave.RowHeadersWidth = 51;
            this.dgvVrstePredstave.RowTemplate.Height = 29;
            this.dgvVrstePredstave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVrstePredstave.Size = new System.Drawing.Size(373, 216);
            this.dgvVrstePredstave.TabIndex = 34;
            this.dgvVrstePredstave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellContentClick);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(115, 20);
            this.lblNaziv.TabIndex = 33;
            this.lblNaziv.Text = "Naziv predstave";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(12, 32);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.ReadOnly = true;
            this.txtNazivPredstave.Size = new System.Drawing.Size(373, 27);
            this.txtNazivPredstave.TabIndex = 32;
            // 
            // VrstaPredstave
            // 
            this.VrstaPredstave.DataPropertyName = "VrstaPredstave";
            this.VrstaPredstave.HeaderText = "Vrsta predstave";
            this.VrstaPredstave.MinimumWidth = 6;
            this.VrstaPredstave.Name = "VrstaPredstave";
            this.VrstaPredstave.ReadOnly = true;
            this.VrstaPredstave.Width = 125;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // frmPrikazPredstavaVrstaPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 308);
            this.Controls.Add(this.dgvVrstePredstave);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivPredstave);
            this.Name = "frmPrikazPredstavaVrstaPredstave";
            this.Text = "Prikaz vrsta predstave";
            this.Load += new System.EventHandler(this.frmPrikazPredstavaGlumac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePredstave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvVrstePredstave;
        private DataGridViewTextBoxColumn VrstaPredstave;
        private DataGridViewButtonColumn Obrisi;
        private Label lblNaziv;
        private TextBox txtNazivPredstave;
    }
}