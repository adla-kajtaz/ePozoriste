namespace ePozoriste.WinUI
{
    partial class frmDodajSalu
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
            this.lblBrSjedistaPoRedu = new System.Windows.Forms.Label();
            this.txtBrSjedistaPoRedu = new System.Windows.Forms.TextBox();
            this.lblBrRedova = new System.Windows.Forms.Label();
            this.txtBrRedova = new System.Windows.Forms.TextBox();
            this.lblPozoriste = new System.Windows.Forms.Label();
            this.cmbPozorista = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lbBrSjedista = new System.Windows.Forms.Label();
            this.txtBrSjedista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBrSjedistaPoRedu
            // 
            this.lblBrSjedistaPoRedu.AutoSize = true;
            this.lblBrSjedistaPoRedu.Location = new System.Drawing.Point(292, 62);
            this.lblBrSjedistaPoRedu.Name = "lblBrSjedistaPoRedu";
            this.lblBrSjedistaPoRedu.Size = new System.Drawing.Size(146, 20);
            this.lblBrSjedistaPoRedu.TabIndex = 38;
            this.lblBrSjedistaPoRedu.Text = "Broj sjedista po redu";
            // 
            // txtBrSjedistaPoRedu
            // 
            this.txtBrSjedistaPoRedu.Location = new System.Drawing.Point(292, 85);
            this.txtBrSjedistaPoRedu.Name = "txtBrSjedistaPoRedu";
            this.txtBrSjedistaPoRedu.Size = new System.Drawing.Size(241, 27);
            this.txtBrSjedistaPoRedu.TabIndex = 37;
            // 
            // lblBrRedova
            // 
            this.lblBrRedova.AutoSize = true;
            this.lblBrRedova.Location = new System.Drawing.Point(292, 9);
            this.lblBrRedova.Name = "lblBrRedova";
            this.lblBrRedova.Size = new System.Drawing.Size(86, 20);
            this.lblBrRedova.TabIndex = 36;
            this.lblBrRedova.Text = "Broj redova";
            // 
            // txtBrRedova
            // 
            this.txtBrRedova.Location = new System.Drawing.Point(292, 32);
            this.txtBrRedova.Name = "txtBrRedova";
            this.txtBrRedova.Size = new System.Drawing.Size(241, 27);
            this.txtBrRedova.TabIndex = 35;
            // 
            // lblPozoriste
            // 
            this.lblPozoriste.AutoSize = true;
            this.lblPozoriste.Location = new System.Drawing.Point(12, 62);
            this.lblPozoriste.Name = "lblPozoriste";
            this.lblPozoriste.Size = new System.Drawing.Size(69, 20);
            this.lblPozoriste.TabIndex = 32;
            this.lblPozoriste.Text = "Pozoriste";
            // 
            // cmbPozorista
            // 
            this.cmbPozorista.FormattingEnabled = true;
            this.cmbPozorista.Location = new System.Drawing.Point(12, 85);
            this.cmbPozorista.Name = "cmbPozorista";
            this.cmbPozorista.Size = new System.Drawing.Size(241, 28);
            this.cmbPozorista.TabIndex = 31;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 20);
            this.lblNaziv.TabIndex = 30;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(241, 27);
            this.txtNaziv.TabIndex = 29;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(292, 137);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(241, 29);
            this.btnSpremi.TabIndex = 28;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lbBrSjedista
            // 
            this.lbBrSjedista.AutoSize = true;
            this.lbBrSjedista.Location = new System.Drawing.Point(12, 116);
            this.lbBrSjedista.Name = "lbBrSjedista";
            this.lbBrSjedista.Size = new System.Drawing.Size(90, 20);
            this.lbBrSjedista.TabIndex = 40;
            this.lbBrSjedista.Text = "Broj sjedista";
            // 
            // txtBrSjedista
            // 
            this.txtBrSjedista.Location = new System.Drawing.Point(12, 139);
            this.txtBrSjedista.Name = "txtBrSjedista";
            this.txtBrSjedista.Size = new System.Drawing.Size(241, 27);
            this.txtBrSjedista.TabIndex = 39;
            // 
            // frmDodajSalu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 195);
            this.Controls.Add(this.lbBrSjedista);
            this.Controls.Add(this.txtBrSjedista);
            this.Controls.Add(this.lblBrSjedistaPoRedu);
            this.Controls.Add(this.txtBrSjedistaPoRedu);
            this.Controls.Add(this.lblBrRedova);
            this.Controls.Add(this.txtBrRedova);
            this.Controls.Add(this.lblPozoriste);
            this.Controls.Add(this.cmbPozorista);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDodajSalu";
            this.Text = "Dodaj Salu";
            this.Load += new System.EventHandler(this.frmDodajSalu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBrSjedistaPoRedu;
        private TextBox txtBrSjedistaPoRedu;
        private Label lblBrRedova;
        private TextBox txtBrRedova;
        private Label lblPozoriste;
        private ComboBox cmbPozorista;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private Button btnSpremi;
        private Label lbBrSjedista;
        private TextBox txtBrSjedista;
    }
}