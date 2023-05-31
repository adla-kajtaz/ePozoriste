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
            this.lblOdabirVrste = new System.Windows.Forms.Label();
            this.cmbVrstePredstave = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOdabirVrste
            // 
            this.lblOdabirVrste.AutoSize = true;
            this.lblOdabirVrste.Location = new System.Drawing.Point(12, 62);
            this.lblOdabirVrste.Name = "lblOdabirVrste";
            this.lblOdabirVrste.Size = new System.Drawing.Size(180, 20);
            this.lblOdabirVrste.TabIndex = 35;
            this.lblOdabirVrste.Text = "Odaberite vrstu predstave";
            // 
            // cmbVrstePredstave
            // 
            this.cmbVrstePredstave.FormattingEnabled = true;
            this.cmbVrstePredstave.Location = new System.Drawing.Point(12, 85);
            this.cmbVrstePredstave.Name = "cmbVrstePredstave";
            this.cmbVrstePredstave.Size = new System.Drawing.Size(332, 28);
            this.cmbVrstePredstave.TabIndex = 34;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 119);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(332, 29);
            this.btnSpremi.TabIndex = 33;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(115, 20);
            this.lblNaziv.TabIndex = 32;
            this.lblNaziv.Text = "Naziv predstave";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(12, 32);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.ReadOnly = true;
            this.txtNazivPredstave.Size = new System.Drawing.Size(332, 27);
            this.txtNazivPredstave.TabIndex = 31;
            // 
            // frmPredstavaVrstaPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 168);
            this.Controls.Add(this.lblOdabirVrste);
            this.Controls.Add(this.cmbVrstePredstave);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivPredstave);
            this.Name = "frmPredstavaVrstaPredstave";
            this.Text = "Vrste predstave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOdabirVrste;
        private ComboBox cmbVrstePredstave;
        private Button btnSpremi;
        private Label lblNaziv;
        private TextBox txtNazivPredstave;
    }
}