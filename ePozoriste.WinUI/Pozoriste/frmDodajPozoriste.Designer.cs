namespace ePozoriste.WinUI
{
    partial class frmDodajPozoriste
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
            this.lblGrad = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblWebStranica = new System.Windows.Forms.Label();
            this.txtWebStranica = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBrTelefona = new System.Windows.Forms.Label();
            this.txtBrTelefona = new System.Windows.Forms.TextBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(12, 115);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(41, 20);
            this.lblGrad.TabIndex = 21;
            this.lblGrad.Text = "Grad";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(12, 138);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(241, 28);
            this.cmbGradovi.TabIndex = 20;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 20);
            this.lblNaziv.TabIndex = 19;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(241, 27);
            this.txtNaziv.TabIndex = 18;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(439, 171);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(94, 29);
            this.btnSpremi.TabIndex = 17;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(12, 62);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(55, 20);
            this.lblAdresa.TabIndex = 23;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(12, 85);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(241, 27);
            this.txtAdresa.TabIndex = 22;
            // 
            // lblWebStranica
            // 
            this.lblWebStranica.AutoSize = true;
            this.lblWebStranica.Location = new System.Drawing.Point(292, 9);
            this.lblWebStranica.Name = "lblWebStranica";
            this.lblWebStranica.Size = new System.Drawing.Size(94, 20);
            this.lblWebStranica.TabIndex = 25;
            this.lblWebStranica.Text = "Web stranica";
            // 
            // txtWebStranica
            // 
            this.txtWebStranica.Location = new System.Drawing.Point(292, 32);
            this.txtWebStranica.Name = "txtWebStranica";
            this.txtWebStranica.Size = new System.Drawing.Size(241, 27);
            this.txtWebStranica.TabIndex = 24;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(292, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(292, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 27);
            this.txtEmail.TabIndex = 26;
            // 
            // lblBrTelefona
            // 
            this.lblBrTelefona.AutoSize = true;
            this.lblBrTelefona.Location = new System.Drawing.Point(292, 115);
            this.lblBrTelefona.Name = "lblBrTelefona";
            this.lblBrTelefona.Size = new System.Drawing.Size(95, 20);
            this.lblBrTelefona.TabIndex = 29;
            this.lblBrTelefona.Text = "Broj telefona";
            // 
            // txtBrTelefona
            // 
            this.txtBrTelefona.Location = new System.Drawing.Point(292, 138);
            this.txtBrTelefona.Name = "txtBrTelefona";
            this.txtBrTelefona.Size = new System.Drawing.Size(241, 27);
            this.txtBrTelefona.TabIndex = 28;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(12, 172);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(80, 24);
            this.cbAktivan.TabIndex = 32;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // frmDodajPozoriste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 219);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.lblBrTelefona);
            this.Controls.Add(this.txtBrTelefona);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblWebStranica);
            this.Controls.Add(this.txtWebStranica);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDodajPozoriste";
            this.Text = "Dodaj Pozoriste";
            this.Load += new System.EventHandler(this.frmDodajPozoriste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGrad;
        private ComboBox cmbGradovi;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private Button btnSpremi;
        private Label lblAdresa;
        private TextBox txtAdresa;
        private Label lblWebStranica;
        private TextBox txtWebStranica;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblBrTelefona;
        private TextBox txtBrTelefona;
        private CheckBox cbAktivan;
    }
}