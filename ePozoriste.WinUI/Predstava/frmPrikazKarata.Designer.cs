namespace ePozoriste.WinUI
{
    partial class frmPrikazKarata
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
            this.dgvKarte = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojReda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjedište = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAktivna = new System.Windows.Forms.CheckBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnSjedista = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKarte
            // 
            this.dgvKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Aktivna,
            this.BrojSjedista,
            this.BrojReda,
            this.Sjedište});
            this.dgvKarte.Location = new System.Drawing.Point(12, 42);
            this.dgvKarte.Name = "dgvKarte";
            this.dgvKarte.RowHeadersWidth = 51;
            this.dgvKarte.RowTemplate.Height = 29;
            this.dgvKarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarte.Size = new System.Drawing.Size(678, 369);
            this.dgvKarte.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KartaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Aktivna
            // 
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.MinimumWidth = 6;
            this.Aktivna.Name = "Aktivna";
            this.Aktivna.ReadOnly = true;
            this.Aktivna.Width = 125;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedišta";
            this.BrojSjedista.MinimumWidth = 6;
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            this.BrojSjedista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BrojSjedista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BrojSjedista.Width = 125;
            // 
            // BrojReda
            // 
            this.BrojReda.DataPropertyName = "BrojReda";
            this.BrojReda.HeaderText = "Broj reda";
            this.BrojReda.MinimumWidth = 6;
            this.BrojReda.Name = "BrojReda";
            this.BrojReda.ReadOnly = true;
            this.BrojReda.Width = 125;
            // 
            // Sjedište
            // 
            this.Sjedište.DataPropertyName = "Sjediste";
            this.Sjedište.HeaderText = "Sjedište";
            this.Sjedište.MinimumWidth = 6;
            this.Sjedište.Name = "Sjedište";
            this.Sjedište.ReadOnly = true;
            this.Sjedište.Width = 125;
            // 
            // cbAktivna
            // 
            this.cbAktivna.AutoSize = true;
            this.cbAktivna.Location = new System.Drawing.Point(12, 12);
            this.cbAktivna.Name = "cbAktivna";
            this.cbAktivna.Size = new System.Drawing.Size(80, 24);
            this.cbAktivna.TabIndex = 16;
            this.cbAktivna.Text = "Aktivna";
            this.cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(98, 7);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(191, 29);
            this.btnPrikazi.TabIndex = 17;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnSjedista
            // 
            this.btnSjedista.Location = new System.Drawing.Point(492, 7);
            this.btnSjedista.Name = "btnSjedista";
            this.btnSjedista.Size = new System.Drawing.Size(198, 29);
            this.btnSjedista.TabIndex = 18;
            this.btnSjedista.Text = "Prikaz sjedista";
            this.btnSjedista.UseVisualStyleBackColor = true;
            this.btnSjedista.Click += new System.EventHandler(this.btnSjedista_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(295, 7);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(191, 29);
            this.btnObrisi.TabIndex = 19;
            this.btnObrisi.Text = "Obrisi karte";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmPrikazKarata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 430);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSjedista);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cbAktivna);
            this.Controls.Add(this.dgvKarte);
            this.Name = "frmPrikazKarata";
            this.Text = "Prikaz Karata";
            this.Load += new System.EventHandler(this.frmPrikazKarata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvKarte;
        private CheckBox cbAktivna;
        private Button btnPrikazi;
        private Button btnSjedista;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewTextBoxColumn BrojSjedista;
        private DataGridViewTextBoxColumn BrojReda;
        private DataGridViewTextBoxColumn Sjedište;
        private Button btnObrisi;
    }
}