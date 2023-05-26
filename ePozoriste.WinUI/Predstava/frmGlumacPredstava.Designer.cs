namespace ePozoriste.WinUI
{
    partial class frmGlumacPredstava
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.cblGlumci = new System.Windows.Forms.CheckedListBox();
            this.lblGlumciPredstava = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(115, 20);
            this.lblNaziv.TabIndex = 23;
            this.lblNaziv.Text = "Naziv predstave";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(12, 32);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.ReadOnly = true;
            this.txtNazivPredstave.Size = new System.Drawing.Size(332, 27);
            this.txtNazivPredstave.TabIndex = 22;
            // 
            // cblGlumci
            // 
            this.cblGlumci.FormattingEnabled = true;
            this.cblGlumci.Location = new System.Drawing.Point(12, 85);
            this.cblGlumci.Name = "cblGlumci";
            this.cblGlumci.Size = new System.Drawing.Size(332, 158);
            this.cblGlumci.TabIndex = 24;
            // 
            // lblGlumciPredstava
            // 
            this.lblGlumciPredstava.AutoSize = true;
            this.lblGlumciPredstava.Location = new System.Drawing.Point(12, 62);
            this.lblGlumciPredstava.Name = "lblGlumciPredstava";
            this.lblGlumciPredstava.Size = new System.Drawing.Size(285, 20);
            this.lblGlumciPredstava.TabIndex = 25;
            this.lblGlumciPredstava.Text = "Odaberite glumce za navedenu predstavu";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 249);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(332, 29);
            this.btnSpremi.TabIndex = 26;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // frmGlumacPredstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 305);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblGlumciPredstava);
            this.Controls.Add(this.cblGlumci);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivPredstave);
            this.Name = "frmGlumacPredstava";
            this.Text = "Glumci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNaziv;
        private TextBox txtNazivPredstave;
        private CheckedListBox cblGlumci;
        private Label lblGlumciPredstava;
        private Button btnSpremi;
    }
}