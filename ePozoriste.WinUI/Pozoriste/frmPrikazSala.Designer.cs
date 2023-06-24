namespace ePozoriste.WinUI
{
    partial class frmPrikazSala
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
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrRedova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrSjedistaPoRedu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PrikaziTermine = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(556, 37);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(145, 29);
            this.btnPrikazi.TabIndex = 21;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.BrSjedista,
            this.BrRedova,
            this.BrSjedistaPoRedu,
            this.Uredi,
            this.Obrisi,
            this.PrikaziTermine});
            this.dgvSale.Location = new System.Drawing.Point(6, 36);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 29;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(837, 417);
            this.dgvSale.TabIndex = 20;
            this.dgvSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(707, 37);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(136, 29);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Nova sala";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 39);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(288, 27);
            this.txtPretraga.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 87);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga sala";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSale);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 477);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale";
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
            // BrSjedista
            // 
            this.BrSjedista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrSjedista.DataPropertyName = "BrSjedista";
            this.BrSjedista.HeaderText = "Broj sjedista";
            this.BrSjedista.MinimumWidth = 6;
            this.BrSjedista.Name = "BrSjedista";
            // 
            // BrRedova
            // 
            this.BrRedova.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrRedova.DataPropertyName = "BrRedova";
            this.BrRedova.HeaderText = "Broj redova";
            this.BrRedova.MinimumWidth = 6;
            this.BrRedova.Name = "BrRedova";
            this.BrRedova.ReadOnly = true;
            // 
            // BrSjedistaPoRedu
            // 
            this.BrSjedistaPoRedu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrSjedistaPoRedu.DataPropertyName = "BrSjedistaPoRedu";
            this.BrSjedistaPoRedu.HeaderText = "Broj sjedista po redu";
            this.BrSjedistaPoRedu.MinimumWidth = 6;
            this.BrSjedistaPoRedu.Name = "BrSjedistaPoRedu";
            this.BrSjedistaPoRedu.ReadOnly = true;
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
            // PrikaziTermine
            // 
            this.PrikaziTermine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrikaziTermine.HeaderText = "Prikazi termine";
            this.PrikaziTermine.MinimumWidth = 6;
            this.PrikaziTermine.Name = "PrikaziTermine";
            this.PrikaziTermine.ReadOnly = true;
            this.PrikaziTermine.Text = "Prikazi termine";
            this.PrikaziTermine.UseColumnTextForButtonValue = true;
            // 
            // frmPrikazSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazSala";
            this.Text = "Prikaz sala";
            this.Load += new System.EventHandler(this.frmPrikazSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvSale;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn BrSjedista;
        private DataGridViewTextBoxColumn BrRedova;
        private DataGridViewTextBoxColumn BrSjedistaPoRedu;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private DataGridViewButtonColumn PrikaziTermine;
        private GroupBox groupBox2;
    }
}