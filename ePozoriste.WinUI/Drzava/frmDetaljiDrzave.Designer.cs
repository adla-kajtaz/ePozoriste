namespace ePozoriste.WinUI
{
    partial class frmDetaljiDrzave
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
            this.components = new System.ComponentModel.Container();
            this.lblSkracenica = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtSkracenica = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errSkracenica = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errSkracenica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkracenica
            // 
            this.lblSkracenica.AutoSize = true;
            this.lblSkracenica.Location = new System.Drawing.Point(12, 76);
            this.lblSkracenica.Name = "lblSkracenica";
            this.lblSkracenica.Size = new System.Drawing.Size(79, 20);
            this.lblSkracenica.TabIndex = 9;
            this.lblSkracenica.Text = "Skracenica";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 20);
            this.lblNaziv.TabIndex = 8;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtSkracenica
            // 
            this.txtSkracenica.Location = new System.Drawing.Point(12, 99);
            this.txtSkracenica.Name = "txtSkracenica";
            this.txtSkracenica.Size = new System.Drawing.Size(241, 27);
            this.txtSkracenica.TabIndex = 7;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(241, 27);
            this.txtNaziv.TabIndex = 6;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(159, 153);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(94, 29);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // errSkracenica
            // 
            this.errSkracenica.ContainerControl = this;
            // 
            // errNaziv
            // 
            this.errNaziv.ContainerControl = this;
            // 
            // frmDetaljiDrzave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 208);
            this.Controls.Add(this.lblSkracenica);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtSkracenica);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDetaljiDrzave";
            this.Text = "Detalji Drzave";
            this.Load += new System.EventHandler(this.frmDetaljiDrzave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errSkracenica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSkracenica;
        private Label lblNaziv;
        private TextBox txtSkracenica;
        private TextBox txtNaziv;
        private Button btnSpremi;
        private ErrorProvider errSkracenica;
        private ErrorProvider errNaziv;
    }
}