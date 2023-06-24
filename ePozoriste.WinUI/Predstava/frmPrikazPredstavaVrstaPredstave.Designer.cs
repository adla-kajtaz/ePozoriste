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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VrstaPredstave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePredstave)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVrstePredstave
            // 
            this.dgvVrstePredstave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstePredstave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaPredstave,
            this.Obrisi});
            this.dgvVrstePredstave.Location = new System.Drawing.Point(6, 26);
            this.dgvVrstePredstave.Name = "dgvVrstePredstave";
            this.dgvVrstePredstave.RowHeadersWidth = 51;
            this.dgvVrstePredstave.RowTemplate.Height = 29;
            this.dgvVrstePredstave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVrstePredstave.Size = new System.Drawing.Size(523, 300);
            this.dgvVrstePredstave.TabIndex = 34;
            this.dgvVrstePredstave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellContentClick);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(6, 35);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(76, 20);
            this.lblNaziv.TabIndex = 33;
            this.lblNaziv.Text = "Predstava:";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(6, 58);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.ReadOnly = true;
            this.txtNazivPredstave.Size = new System.Drawing.Size(314, 27);
            this.txtNazivPredstave.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNaziv);
            this.groupBox1.Controls.Add(this.txtNazivPredstave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 111);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o predstavi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVrstePredstave);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 332);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrste predstave";
            // 
            // VrstaPredstave
            // 
            this.VrstaPredstave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VrstaPredstave.DataPropertyName = "VrstaPredstave";
            this.VrstaPredstave.HeaderText = "Vrsta predstave";
            this.VrstaPredstave.MinimumWidth = 6;
            this.VrstaPredstave.Name = "VrstaPredstave";
            this.VrstaPredstave.ReadOnly = true;
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
            // frmPrikazPredstavaVrstaPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazPredstavaVrstaPredstave";
            this.Text = "Prikaz vrsta predstave";
            this.Load += new System.EventHandler(this.frmPrikazPredstavaGlumac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstePredstave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvVrstePredstave;
        private Label lblNaziv;
        private TextBox txtNazivPredstave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn VrstaPredstave;
        private DataGridViewButtonColumn Obrisi;
    }
}