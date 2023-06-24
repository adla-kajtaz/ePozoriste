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
            this.components = new System.ComponentModel.Container();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNazivPredstave = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtNazivUloge = new System.Windows.Forms.TextBox();
            this.lblNazivUloge = new System.Windows.Forms.Label();
            this.cmbGlumac = new System.Windows.Forms.ComboBox();
            this.lblOdabirGlumca = new System.Windows.Forms.Label();
            this.errNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGlumac = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGlumac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(76, 20);
            this.lblNaziv.TabIndex = 23;
            this.lblNaziv.Text = "Predstava:";
            // 
            // txtNazivPredstave
            // 
            this.txtNazivPredstave.Location = new System.Drawing.Point(12, 32);
            this.txtNazivPredstave.Name = "txtNazivPredstave";
            this.txtNazivPredstave.ReadOnly = true;
            this.txtNazivPredstave.Size = new System.Drawing.Size(332, 27);
            this.txtNazivPredstave.TabIndex = 22;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 172);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(332, 29);
            this.btnSpremi.TabIndex = 26;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtNazivUloge
            // 
            this.txtNazivUloge.Location = new System.Drawing.Point(12, 85);
            this.txtNazivUloge.Name = "txtNazivUloge";
            this.txtNazivUloge.Size = new System.Drawing.Size(332, 27);
            this.txtNazivUloge.TabIndex = 27;
            // 
            // lblNazivUloge
            // 
            this.lblNazivUloge.AutoSize = true;
            this.lblNazivUloge.Location = new System.Drawing.Point(12, 62);
            this.lblNazivUloge.Name = "lblNazivUloge";
            this.lblNazivUloge.Size = new System.Drawing.Size(91, 20);
            this.lblNazivUloge.TabIndex = 28;
            this.lblNazivUloge.Text = "Naziv uloge:";
            // 
            // cmbGlumac
            // 
            this.cmbGlumac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGlumac.FormattingEnabled = true;
            this.cmbGlumac.Location = new System.Drawing.Point(12, 138);
            this.cmbGlumac.Name = "cmbGlumac";
            this.cmbGlumac.Size = new System.Drawing.Size(332, 28);
            this.cmbGlumac.TabIndex = 29;
            // 
            // lblOdabirGlumca
            // 
            this.lblOdabirGlumca.AutoSize = true;
            this.lblOdabirGlumca.Location = new System.Drawing.Point(12, 115);
            this.lblOdabirGlumca.Name = "lblOdabirGlumca";
            this.lblOdabirGlumca.Size = new System.Drawing.Size(62, 20);
            this.lblOdabirGlumca.TabIndex = 30;
            this.lblOdabirGlumca.Text = "Glumac:";
            // 
            // errNaziv
            // 
            this.errNaziv.ContainerControl = this;
            // 
            // errGlumac
            // 
            this.errGlumac.ContainerControl = this;
            // 
            // frmGlumacPredstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 220);
            this.Controls.Add(this.lblOdabirGlumca);
            this.Controls.Add(this.cmbGlumac);
            this.Controls.Add(this.lblNazivUloge);
            this.Controls.Add(this.txtNazivUloge);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivPredstave);
            this.Name = "frmGlumacPredstava";
            this.Text = "Glumac";
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGlumac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNaziv;
        private TextBox txtNazivPredstave;
        private Button btnSpremi;
        private TextBox txtNazivUloge;
        private Label lblNazivUloge;
        private ComboBox cmbGlumac;
        private Label lblOdabirGlumca;
        private ErrorProvider errNaziv;
        private ErrorProvider errGlumac;
    }
}