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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NazivUloge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Glumac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavaGlumci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(6, 34);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(76, 20);
            this.lblNaziv.TabIndex = 30;
            this.lblNaziv.Text = "Predstava:";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(6, 66);
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
            this.dgvPredstavaGlumci.Location = new System.Drawing.Point(6, 39);
            this.dgvPredstavaGlumci.Name = "dgvPredstavaGlumci";
            this.dgvPredstavaGlumci.RowHeadersWidth = 51;
            this.dgvPredstavaGlumci.RowTemplate.Height = 29;
            this.dgvPredstavaGlumci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstavaGlumci.Size = new System.Drawing.Size(618, 304);
            this.dgvPredstavaGlumci.TabIndex = 31;
            this.dgvPredstavaGlumci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNazivPredstave);
            this.groupBox1.Controls.Add(this.lblNaziv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 111);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o predstavi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPredstavaGlumci);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 362);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Glumci";
            // 
            // NazivUloge
            // 
            this.NazivUloge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivUloge.DataPropertyName = "NazivUloge";
            this.NazivUloge.HeaderText = "Naziv uloge";
            this.NazivUloge.MinimumWidth = 6;
            this.NazivUloge.Name = "NazivUloge";
            this.NazivUloge.ReadOnly = true;
            // 
            // Glumac
            // 
            this.Glumac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Glumac.DataPropertyName = "Glumac";
            this.Glumac.HeaderText = "Glumac";
            this.Glumac.MinimumWidth = 6;
            this.Glumac.Name = "Glumac";
            this.Glumac.ReadOnly = true;
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
            // frmPrikazPredstavaGlumac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazPredstavaGlumac";
            this.Text = "Prikaz glumaca ";
            this.Load += new System.EventHandler(this.frmPrikazPredstavaGlumac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavaGlumci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNaziv;
        private TextBox txtNazivPredstave;
        private DataGridView dgvPredstavaGlumci;
        private DataGridViewTextBoxColumn NazivUloge;
        private DataGridViewTextBoxColumn Glumac;
        private DataGridViewButtonColumn Obrisi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}