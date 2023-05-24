namespace ePozoriste.WinUI
{
    partial class frmDodajGlumca
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
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 20);
            this.lblIme.TabIndex = 17;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 32);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(332, 27);
            this.txtIme.TabIndex = 16;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(250, 118);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(94, 29);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 62);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(62, 20);
            this.lblPrezime.TabIndex = 19;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(12, 85);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(332, 27);
            this.txtPrezime.TabIndex = 18;
            // 
            // frmDodajGlumca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 155);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDodajGlumca";
            this.Text = "Dodaj glumca";
            this.Load += new System.EventHandler(this.frmDodajGlumca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIme;
        private TextBox txtIme;
        private Button btnSpremi;
        private Label lblPrezime;
        private TextBox txtPrezime;
    }
}