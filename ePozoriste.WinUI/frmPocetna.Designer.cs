namespace ePozoriste.WinUI
{
    partial class frmPocetna
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
            this.btnDrzava = new System.Windows.Forms.Button();
            this.btnGrad = new System.Windows.Forms.Button();
            this.btnObavijestKategorija = new System.Windows.Forms.Button();
            this.btnObavijest = new System.Windows.Forms.Button();
            this.btnPozoriste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrzava
            // 
            this.btnDrzava.Location = new System.Drawing.Point(12, 12);
            this.btnDrzava.Name = "btnDrzava";
            this.btnDrzava.Size = new System.Drawing.Size(100, 74);
            this.btnDrzava.TabIndex = 0;
            this.btnDrzava.Text = "Drzava";
            this.btnDrzava.UseVisualStyleBackColor = true;
            this.btnDrzava.Click += new System.EventHandler(this.btnDrzava_Click);
            // 
            // btnGrad
            // 
            this.btnGrad.Location = new System.Drawing.Point(12, 91);
            this.btnGrad.Name = "btnGrad";
            this.btnGrad.Size = new System.Drawing.Size(100, 86);
            this.btnGrad.TabIndex = 1;
            this.btnGrad.Text = "Grad";
            this.btnGrad.UseVisualStyleBackColor = true;
            this.btnGrad.Click += new System.EventHandler(this.btnGrad_Click);
            // 
            // btnObavijestKategorija
            // 
            this.btnObavijestKategorija.Location = new System.Drawing.Point(129, 12);
            this.btnObavijestKategorija.Name = "btnObavijestKategorija";
            this.btnObavijestKategorija.Size = new System.Drawing.Size(100, 74);
            this.btnObavijestKategorija.TabIndex = 2;
            this.btnObavijestKategorija.Text = "Obavijest kategorija";
            this.btnObavijestKategorija.UseVisualStyleBackColor = true;
            this.btnObavijestKategorija.Click += new System.EventHandler(this.btnObavijestKategorija_Click);
            // 
            // btnObavijest
            // 
            this.btnObavijest.Location = new System.Drawing.Point(129, 92);
            this.btnObavijest.Name = "btnObavijest";
            this.btnObavijest.Size = new System.Drawing.Size(100, 85);
            this.btnObavijest.TabIndex = 3;
            this.btnObavijest.Text = "Obavijest";
            this.btnObavijest.UseVisualStyleBackColor = true;
            this.btnObavijest.Click += new System.EventHandler(this.btnObavijest_Click);
            // 
            // btnPozoriste
            // 
            this.btnPozoriste.Location = new System.Drawing.Point(235, 12);
            this.btnPozoriste.Name = "btnPozoriste";
            this.btnPozoriste.Size = new System.Drawing.Size(100, 74);
            this.btnPozoriste.TabIndex = 4;
            this.btnPozoriste.Text = "Pozoriste";
            this.btnPozoriste.UseVisualStyleBackColor = true;
            this.btnPozoriste.Click += new System.EventHandler(this.btnPozoriste_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 209);
            this.Controls.Add(this.btnPozoriste);
            this.Controls.Add(this.btnObavijest);
            this.Controls.Add(this.btnObavijestKategorija);
            this.Controls.Add(this.btnGrad);
            this.Controls.Add(this.btnDrzava);
            this.Name = "frmPocetna";
            this.Text = "Pocetna";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDrzava;
        private Button btnGrad;
        private Button btnObavijestKategorija;
        private Button btnObavijest;
        private Button btnPozoriste;
    }
}