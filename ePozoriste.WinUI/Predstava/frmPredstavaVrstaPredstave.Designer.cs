namespace ePozoriste.WinUI
{
    partial class frmPredstavaVrstaPredstave
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
            this.lblVrstePredstave = new System.Windows.Forms.Label();
            this.cblVrstePredstave = new System.Windows.Forms.CheckedListBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 249);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(332, 29);
            this.btnSpremi.TabIndex = 31;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // lblVrstePredstave
            // 
            this.lblVrstePredstave.AutoSize = true;
            this.lblVrstePredstave.Location = new System.Drawing.Point(12, 62);
            this.lblVrstePredstave.Name = "lblVrstePredstave";
            this.lblVrstePredstave.Size = new System.Drawing.Size(180, 20);
            this.lblVrstePredstave.TabIndex = 30;
            this.lblVrstePredstave.Text = "Odaberite vrste predstave";
            // 
            // cblVrstePredstave
            // 
            this.cblVrstePredstave.FormattingEnabled = true;
            this.cblVrstePredstave.Location = new System.Drawing.Point(12, 85);
            this.cblVrstePredstave.Name = "cblVrstePredstave";
            this.cblVrstePredstave.Size = new System.Drawing.Size(332, 158);
            this.cblVrstePredstave.TabIndex = 29;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(115, 20);
            this.lblNaziv.TabIndex = 28;
            this.lblNaziv.Text = "Naziv predstave";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(12, 32);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.ReadOnly = true;
            this.txtNazivPredstave.Size = new System.Drawing.Size(332, 27);
            this.txtNazivPredstave.TabIndex = 27;
            // 
            // frmPredstavaVrstaPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 293);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblVrstePredstave);
            this.Controls.Add(this.cblVrstePredstave);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivPredstave);
            this.Name = "frmPredstavaVrstaPredstave";
            this.Text = "Vrste predstave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSpremi;
        private Label lblVrstePredstave;
        private CheckedListBox cblVrstePredstave;
        private Label lblNaziv;
        private TextBox txtNazivPredstave;
    }
}