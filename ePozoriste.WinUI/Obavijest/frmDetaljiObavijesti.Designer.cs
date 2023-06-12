namespace ePozoriste.WinUI
{
    partial class frmDetaljiObavijesti
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblPodnaslov = new System.Windows.Forms.Label();
            this.txtPodnaslov = new System.Windows.Forms.TextBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblSadrzaj = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(389, 280);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(332, 29);
            this.btnSpremi.TabIndex = 43;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblPodnaslov
            // 
            this.lblPodnaslov.AutoSize = true;
            this.lblPodnaslov.Location = new System.Drawing.Point(12, 62);
            this.lblPodnaslov.Name = "lblPodnaslov";
            this.lblPodnaslov.Size = new System.Drawing.Size(76, 20);
            this.lblPodnaslov.TabIndex = 42;
            this.lblPodnaslov.Text = "Podnaslov";
            // 
            // txtPodnaslov
            // 
            this.txtPodnaslov.Location = new System.Drawing.Point(12, 85);
            this.txtPodnaslov.Name = "txtPodnaslov";
            this.txtPodnaslov.Size = new System.Drawing.Size(332, 27);
            this.txtPodnaslov.TabIndex = 41;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(389, 9);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(40, 20);
            this.lblSlika.TabIndex = 40;
            this.lblSlika.Text = "Slika";
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSlika.Location = new System.Drawing.Point(389, 32);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(222, 166);
            this.pbSlika.TabIndex = 39;
            this.pbSlika.TabStop = false;
            // 
            // lblSadrzaj
            // 
            this.lblSadrzaj.AutoSize = true;
            this.lblSadrzaj.Location = new System.Drawing.Point(12, 115);
            this.lblSadrzaj.Name = "lblSadrzaj";
            this.lblSadrzaj.Size = new System.Drawing.Size(58, 20);
            this.lblSadrzaj.TabIndex = 38;
            this.lblSadrzaj.Text = "Sadržaj";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(12, 138);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSadrzaj.Size = new System.Drawing.Size(332, 171);
            this.txtSadrzaj.TabIndex = 37;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(54, 20);
            this.lblNaslov.TabIndex = 36;
            this.lblNaslov.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(12, 32);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(332, 27);
            this.txtNaslov.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Odaberite kategoriju obavijesti: ";
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(389, 224);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(247, 28);
            this.cmbKategorije.TabIndex = 45;
            // 
            // frmDetaljiObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 325);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblPodnaslov);
            this.Controls.Add(this.txtPodnaslov);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lblSadrzaj);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.txtNaslov);
            this.Name = "frmDetaljiObavijesti";
            this.Text = "Detalji obavijesti";
            this.Load += new System.EventHandler(this.frmDetaljiObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSpremi;
        private Label lblPodnaslov;
        private TextBox txtPodnaslov;
        private Label lblSlika;
        private PictureBox pbSlika;
        private Label lblSadrzaj;
        private TextBox txtSadrzaj;
        private Label lblNaslov;
        private TextBox txtNaslov;
        private Label label1;
        private ComboBox cmbKategorije;
    }
}