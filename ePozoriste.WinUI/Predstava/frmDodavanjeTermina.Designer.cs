namespace ePozoriste.WinUI
{
    partial class frmDodavanjeTermina
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
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.cmbPredstave = new System.Windows.Forms.ComboBox();
            this.lblPredstava = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.lblKarta = new System.Windows.Forms.Label();
            this.cbPremijera = new System.Windows.Forms.CheckBox();
            this.cbPredpremijera = new System.Windows.Forms.CheckBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrijemeOdrzavanja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbSale
            // 
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(12, 86);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(250, 28);
            this.cmbSale.TabIndex = 20;
            // 
            // cmbPredstave
            // 
            this.cmbPredstave.FormattingEnabled = true;
            this.cmbPredstave.Location = new System.Drawing.Point(12, 32);
            this.cmbPredstave.Name = "cmbPredstave";
            this.cmbPredstave.Size = new System.Drawing.Size(250, 28);
            this.cmbPredstave.TabIndex = 19;
            // 
            // lblPredstava
            // 
            this.lblPredstava.AutoSize = true;
            this.lblPredstava.Location = new System.Drawing.Point(12, 9);
            this.lblPredstava.Name = "lblPredstava";
            this.lblPredstava.Size = new System.Drawing.Size(148, 20);
            this.lblPredstava.TabIndex = 21;
            this.lblPredstava.Text = "Odaberite predstavu:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(12, 63);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(109, 20);
            this.lblSala.TabIndex = 22;
            this.lblSala.Text = "Odaberite salu:";
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.Location = new System.Drawing.Point(12, 140);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.Size = new System.Drawing.Size(250, 27);
            this.txtCijenaKarte.TabIndex = 23;
            // 
            // lblKarta
            // 
            this.lblKarta.AutoSize = true;
            this.lblKarta.Location = new System.Drawing.Point(12, 117);
            this.lblKarta.Name = "lblKarta";
            this.lblKarta.Size = new System.Drawing.Size(141, 20);
            this.lblKarta.TabIndex = 24;
            this.lblKarta.Text = "Unesite cijenu karte:";
            // 
            // cbPremijera
            // 
            this.cbPremijera.AutoSize = true;
            this.cbPremijera.Location = new System.Drawing.Point(12, 279);
            this.cbPremijera.Name = "cbPremijera";
            this.cbPremijera.Size = new System.Drawing.Size(94, 24);
            this.cbPremijera.TabIndex = 25;
            this.cbPremijera.Text = "Premijera";
            this.cbPremijera.UseVisualStyleBackColor = true;
            // 
            // cbPredpremijera
            // 
            this.cbPredpremijera.AutoSize = true;
            this.cbPredpremijera.Location = new System.Drawing.Point(137, 279);
            this.cbPredpremijera.Name = "cbPredpremijera";
            this.cbPredpremijera.Size = new System.Drawing.Size(125, 24);
            this.cbPredpremijera.TabIndex = 26;
            this.cbPredpremijera.Text = "Predpremijera";
            this.cbPredpremijera.UseVisualStyleBackColor = true;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(12, 193);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(250, 27);
            this.dtpDatum.TabIndex = 27;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 170);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(194, 20);
            this.lblDatum.TabIndex = 28;
            this.lblDatum.Text = "Odaberite datum izvođenja:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 309);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(250, 29);
            this.btnDodaj.TabIndex = 29;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Unesite vrijeme održavanja:";
            // 
            // txtVrijemeOdrzavanja
            // 
            this.txtVrijemeOdrzavanja.Location = new System.Drawing.Point(12, 246);
            this.txtVrijemeOdrzavanja.Name = "txtVrijemeOdrzavanja";
            this.txtVrijemeOdrzavanja.Size = new System.Drawing.Size(250, 27);
            this.txtVrijemeOdrzavanja.TabIndex = 30;
            // 
            // frmDodavanjeTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVrijemeOdrzavanja);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbPredpremijera);
            this.Controls.Add(this.cbPremijera);
            this.Controls.Add(this.lblKarta);
            this.Controls.Add(this.txtCijenaKarte);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblPredstava);
            this.Controls.Add(this.cmbSale);
            this.Controls.Add(this.cmbPredstave);
            this.Name = "frmDodavanjeTermina";
            this.Text = "Dodavanje termina";
            this.Load += new System.EventHandler(this.frmDodavanjeTermina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbSale;
        private ComboBox cmbPredstave;
        private Label lblPredstava;
        private Label lblSala;
        private TextBox txtCijenaKarte;
        private Label lblKarta;
        private CheckBox cbPremijera;
        private CheckBox cbPredpremijera;
        private DateTimePicker dtpDatum;
        private Label lblDatum;
        private Button btnDodaj;
        private Label label1;
        private TextBox txtVrijemeOdrzavanja;
    }
}