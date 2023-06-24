namespace ePozoriste.WinUI
{
    partial class frmPrikazDrzave
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvDrzave = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skracenica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(392, 35);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(124, 29);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvDrzave
            // 
            this.dgvDrzave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrzave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Skracenica,
            this.Uredi,
            this.Obrisi});
            this.dgvDrzave.Location = new System.Drawing.Point(6, 40);
            this.dgvDrzave.Name = "dgvDrzave";
            this.dgvDrzave.RowHeadersWidth = 51;
            this.dgvDrzave.RowTemplate.Height = 29;
            this.dgvDrzave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrzave.Size = new System.Drawing.Size(632, 464);
            this.dgvDrzave.TabIndex = 6;
            this.dgvDrzave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrzava_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(522, 35);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 29);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Nova drzava";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 37);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(380, 27);
            this.txtPretraga.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga drzava";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDrzave);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 523);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drzave";
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Skracenica
            // 
            this.Skracenica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Skracenica.DataPropertyName = "Skracenica";
            this.Skracenica.HeaderText = "Skracenica";
            this.Skracenica.MinimumWidth = 6;
            this.Skracenica.Name = "Skracenica";
            this.Skracenica.ReadOnly = true;
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
            // frmPrikazDrzave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazDrzave";
            this.Text = "Prikaz drzava";
            this.Load += new System.EventHandler(this.frmPrikazDrzava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvDrzave;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Skracenica;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
    }
}