namespace ePozoriste.WinUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label4 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(252, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 200);
            this.label4.TabIndex = 15;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaziv.Location = new System.Drawing.Point(313, 13);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(214, 35);
            this.lblNaziv.TabIndex = 14;
            this.lblNaziv.Text = "ePozoriste :: v1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(496, 191);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(86, 31);
            this.btnPrijava.TabIndex = 12;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(271, 128);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(62, 20);
            this.lblLozinka.TabIndex = 11;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(271, 69);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(109, 20);
            this.lblKorisnickoIme.TabIndex = 10;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(271, 152);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(310, 27);
            this.txtLozinka.TabIndex = 9;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(271, 93);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(310, 27);
            this.txtKorisnickoIme.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 237);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label lblNaziv;
        private PictureBox pictureBox1;
        private Button btnPrijava;
        private Label lblLozinka;
        private Label lblKorisnickoIme;
        private TextBox txtLozinka;
        private TextBox txtKorisnickoIme;
    }
}