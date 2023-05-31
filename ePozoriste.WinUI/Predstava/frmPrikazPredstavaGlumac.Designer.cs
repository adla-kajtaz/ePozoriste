namespace ePozoriste.WinUI
{
    partial class frmPrikazPredstavaGlumac
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.dgvPredstavaGlumci = new System.Windows.Forms.DataGridView();
            this.NazivUloge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Glumac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavaGlumci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(115, 20);
            this.lblNaziv.TabIndex = 30;
            this.lblNaziv.Text = "Naziv predstave";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(12, 32);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.ReadOnly = true;
            this.txtNazivPredstave.Size = new System.Drawing.Size(332, 27);
            this.txtNazivPredstave.TabIndex = 29;
            // 
            // dgvPredstavaGlumci
            // 
            this.dgvPredstavaGlumci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredstavaGlumci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivUloge,
            this.Glumac,
            this.Obrisi});
            this.dgvPredstavaGlumci.Location = new System.Drawing.Point(12, 65);
            this.dgvPredstavaGlumci.Name = "dgvPredstavaGlumci";
            this.dgvPredstavaGlumci.RowHeadersWidth = 51;
            this.dgvPredstavaGlumci.RowTemplate.Height = 29;
            this.dgvPredstavaGlumci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstavaGlumci.Size = new System.Drawing.Size(532, 271);
            this.dgvPredstavaGlumci.TabIndex = 31;
            this.dgvPredstavaGlumci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellContentClick);
            // 
            // NazivUloge
            // 
            this.NazivUloge.DataPropertyName = "NazivUloge";
            this.NazivUloge.HeaderText = "Naziv uloge";
            this.NazivUloge.MinimumWidth = 6;
            this.NazivUloge.Name = "NazivUloge";
            this.NazivUloge.ReadOnly = true;
            this.NazivUloge.Width = 125;
            // 
            // Glumac
            // 
            this.Glumac.DataPropertyName = "Glumac";
            this.Glumac.HeaderText = "Glumac";
            this.Glumac.MinimumWidth = 6;
            this.Glumac.Name = "Glumac";
            this.Glumac.ReadOnly = true;
            this.Glumac.Width = 125;
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
            // frmPrikazPredstavaGlumac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 374);
            this.Controls.Add(this.dgvPredstavaGlumci);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivPredstave);
            this.Name = "frmPrikazPredstavaGlumac";
            this.Text = "Prikaz glumaca za predstavu";
            this.Load += new System.EventHandler(this.frmPrikazPredstavaGlumac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavaGlumci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNaziv;
        private TextBox txtNazivPredstave;
        private DataGridView dgvPredstavaGlumci;
        private DataGridViewTextBoxColumn NazivUloge;
        private DataGridViewTextBoxColumn Glumac;
        private DataGridViewButtonColumn Obrisi;
    }
}