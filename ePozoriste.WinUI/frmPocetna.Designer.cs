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
            this.btnTermini = new System.Windows.Forms.Button();
            this.btnGlumci = new System.Windows.Forms.Button();
            this.btnPredstava = new System.Windows.Forms.Button();
            this.btnVrstaPredstave = new System.Windows.Forms.Button();
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
            this.btnObavijestKategorija.Location = new System.Drawing.Point(118, 12);
            this.btnObavijestKategorija.Name = "btnObavijestKategorija";
            this.btnObavijestKategorija.Size = new System.Drawing.Size(100, 74);
            this.btnObavijestKategorija.TabIndex = 2;
            this.btnObavijestKategorija.Text = "Obavijest kategorija";
            this.btnObavijestKategorija.UseVisualStyleBackColor = true;
            this.btnObavijestKategorija.Click += new System.EventHandler(this.btnObavijestKategorija_Click);
            // 
            // btnObavijest
            // 
            this.btnObavijest.Location = new System.Drawing.Point(118, 92);
            this.btnObavijest.Name = "btnObavijest";
            this.btnObavijest.Size = new System.Drawing.Size(100, 85);
            this.btnObavijest.TabIndex = 3;
            this.btnObavijest.Text = "Obavijest";
            this.btnObavijest.UseVisualStyleBackColor = true;
            this.btnObavijest.Click += new System.EventHandler(this.btnObavijest_Click);
            // 
            // btnPozoriste
            // 
            this.btnPozoriste.Location = new System.Drawing.Point(224, 12);
            this.btnPozoriste.Name = "btnPozoriste";
            this.btnPozoriste.Size = new System.Drawing.Size(100, 74);
            this.btnPozoriste.TabIndex = 4;
            this.btnPozoriste.Text = "Pozoriste";
            this.btnPozoriste.UseVisualStyleBackColor = true;
            this.btnPozoriste.Click += new System.EventHandler(this.btnPozoriste_Click);
            // 
            // btnTermini
            // 
            this.btnTermini.Location = new System.Drawing.Point(436, 12);
            this.btnTermini.Name = "btnTermini";
            this.btnTermini.Size = new System.Drawing.Size(100, 74);
            this.btnTermini.TabIndex = 9;
            this.btnTermini.Text = "Termini";
            this.btnTermini.UseVisualStyleBackColor = true;
            this.btnTermini.Click += new System.EventHandler(this.btnTermini_Click);
            // 
            // btnGlumci
            // 
            this.btnGlumci.Location = new System.Drawing.Point(330, 12);
            this.btnGlumci.Name = "btnGlumci";
            this.btnGlumci.Size = new System.Drawing.Size(100, 74);
            this.btnGlumci.TabIndex = 8;
            this.btnGlumci.Text = "Glumci";
            this.btnGlumci.UseVisualStyleBackColor = true;
            this.btnGlumci.Click += new System.EventHandler(this.btnGlumci_Click);
            // 
            // btnPredstava
            // 
            this.btnPredstava.Location = new System.Drawing.Point(330, 92);
            this.btnPredstava.Name = "btnPredstava";
            this.btnPredstava.Size = new System.Drawing.Size(100, 85);
            this.btnPredstava.TabIndex = 7;
            this.btnPredstava.Text = "Predstava";
            this.btnPredstava.UseVisualStyleBackColor = true;
            this.btnPredstava.Click += new System.EventHandler(this.btnPredstava_Click);
            // 
            // btnVrstaPredstave
            // 
            this.btnVrstaPredstave.Location = new System.Drawing.Point(224, 92);
            this.btnVrstaPredstave.Name = "btnVrstaPredstave";
            this.btnVrstaPredstave.Size = new System.Drawing.Size(100, 84);
            this.btnVrstaPredstave.TabIndex = 6;
            this.btnVrstaPredstave.Text = "Vrsta predstave";
            this.btnVrstaPredstave.UseVisualStyleBackColor = true;
            this.btnVrstaPredstave.Click += new System.EventHandler(this.btnVrstaPredstave_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 189);
            this.Controls.Add(this.btnTermini);
            this.Controls.Add(this.btnGlumci);
            this.Controls.Add(this.btnPredstava);
            this.Controls.Add(this.btnVrstaPredstave);
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
        private Button btnTermini;
        private Button btnGlumci;
        private Button btnPredstava;
        private Button btnVrstaPredstave;
    }
}