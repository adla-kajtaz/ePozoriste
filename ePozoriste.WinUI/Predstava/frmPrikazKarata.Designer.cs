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
            this.cbAktivna = new System.Windows.Forms.CheckBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnSjedista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojReda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjedište = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKarte
            // 
            this.dgvKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojSjedista,
            this.BrojReda,
            this.Sjedište,
            this.Aktivna});
            this.dgvKarte.Location = new System.Drawing.Point(6, 26);
            this.dgvKarte.Name = "dgvKarte";
            this.dgvKarte.RowHeadersWidth = 51;
            this.dgvKarte.RowTemplate.Height = 29;
            this.dgvKarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarte.Size = new System.Drawing.Size(847, 524);
            this.dgvKarte.TabIndex = 15;
            // 
            // cbAktivna
            // 
            this.cbAktivna.AutoSize = true;
            this.cbAktivna.Location = new System.Drawing.Point(6, 39);
            this.cbAktivna.Name = "cbAktivna";
            this.cbAktivna.Size = new System.Drawing.Size(80, 24);
            this.cbAktivna.TabIndex = 16;
            this.cbAktivna.Text = "Aktivna";
            this.cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(92, 36);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(191, 29);
            this.btnPrikazi.TabIndex = 17;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnSjedista
            // 
            this.btnSjedista.Location = new System.Drawing.Point(665, 36);
            this.btnSjedista.Name = "btnSjedista";
            this.btnSjedista.Size = new System.Drawing.Size(188, 29);
            this.btnSjedista.TabIndex = 18;
            this.btnSjedista.Text = "Prikaz sjedista";
            this.btnSjedista.UseVisualStyleBackColor = true;
            this.btnSjedista.Click += new System.EventHandler(this.btnSjedista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnIzvjestaj);
            this.groupBox1.Controls.Add(this.cbAktivna);
            this.groupBox1.Controls.Add(this.btnSjedista);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 81);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga karata";
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(496, 36);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(163, 29);
            this.btnIzvjestaj.TabIndex = 20;
            this.btnIzvjestaj.Text = "Izvjestaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKarte);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 571);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Karte";
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedišta";
            this.BrojSjedista.MinimumWidth = 6;
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            this.BrojSjedista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BrojSjedista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BrojReda
            // 
            this.BrojReda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojReda.DataPropertyName = "BrojReda";
            this.BrojReda.HeaderText = "Broj reda";
            this.BrojReda.MinimumWidth = 6;
            this.BrojReda.Name = "BrojReda";
            this.BrojReda.ReadOnly = true;
            // 
            // Sjedište
            // 
            this.Sjedište.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sjedište.DataPropertyName = "Sjediste";
            this.Sjedište.HeaderText = "Sjedište";
            this.Sjedište.MinimumWidth = 6;
            this.Sjedište.Name = "Sjedište";
            this.Sjedište.ReadOnly = true;
            // 
            // Aktivna
            // 
            this.Aktivna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.MinimumWidth = 6;
            this.Aktivna.Name = "Aktivna";
            this.Aktivna.ReadOnly = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(289, 36);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(201, 29);
            this.btnObrisi.TabIndex = 21;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmPrikazKarata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 702);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazKarata";
            this.Text = "Prikaz karata";
            this.Load += new System.EventHandler(this.frmPrikazKarata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvKarte;
        private CheckBox cbAktivna;
        private Button btnPrikazi;
        private Button btnSjedista;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnIzvjestaj;
        private DataGridViewTextBoxColumn BrojSjedista;
        private DataGridViewTextBoxColumn BrojReda;
        private DataGridViewTextBoxColumn Sjedište;
        private DataGridViewCheckBoxColumn Aktivna;
        private Button btnObrisi;
    }
}