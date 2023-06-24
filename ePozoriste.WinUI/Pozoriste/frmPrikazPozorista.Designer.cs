namespace ePozoriste.WinUI
{
    partial class frmPrikazPozorista
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
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvPozorista = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebStranica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sale = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozorista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(593, 52);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(256, 28);
            this.cmbGradovi.TabIndex = 18;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(855, 51);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(179, 29);
            this.btnPrikazi.TabIndex = 17;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvPozorista
            // 
            this.dgvPozorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPozorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Adresa,
            this.Grad,
            this.WebStranica,
            this.Email,
            this.BrTelefona,
            this.Aktivan,
            this.Uredi,
            this.Obrisi,
            this.Sale});
            this.dgvPozorista.Location = new System.Drawing.Point(6, 38);
            this.dgvPozorista.Name = "dgvPozorista";
            this.dgvPozorista.RowHeadersWidth = 51;
            this.dgvPozorista.RowTemplate.Height = 29;
            this.dgvPozorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPozorista.Size = new System.Drawing.Size(1256, 500);
            this.dgvPozorista.TabIndex = 16;
            this.dgvPozorista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPozorista_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1040, 51);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(184, 29);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Novo pozoriste";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 53);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(581, 27);
            this.txtPretraga.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.cmbGradovi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1293, 104);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga pozorista";
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
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MinimumWidth = 6;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.MinimumWidth = 6;
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WebStranica
            // 
            this.WebStranica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WebStranica.DataPropertyName = "WebStranica";
            this.WebStranica.HeaderText = "Web stranica";
            this.WebStranica.MinimumWidth = 6;
            this.WebStranica.Name = "WebStranica";
            this.WebStranica.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // BrTelefona
            // 
            this.BrTelefona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrTelefona.DataPropertyName = "BrTelefona";
            this.BrTelefona.HeaderText = "Broj telefona";
            this.BrTelefona.MinimumWidth = 6;
            this.BrTelefona.Name = "BrTelefona";
            this.BrTelefona.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
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
            // Sale
            // 
            this.Sale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sale.HeaderText = "Prikaz sala";
            this.Sale.MinimumWidth = 6;
            this.Sale.Name = "Sale";
            this.Sale.Text = "Prikaz sala";
            this.Sale.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gradovi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPozorista);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1293, 563);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pozorista";
            // 
            // frmPrikazPozorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazPozorista";
            this.Text = "Prikaz pozorista";
            this.Load += new System.EventHandler(this.frmPrikazPozorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozorista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbGradovi;
        private Button btnPrikazi;
        private DataGridView dgvPozorista;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Adresa;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn WebStranica;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn BrTelefona;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private DataGridViewButtonColumn Sale;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
    }
}