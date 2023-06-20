namespace ePozoriste.WinUI
{
    partial class frmDetaljiGrada
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
            this.lblPostanskiBr = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtPostanskiBr = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cmbDrzave = new System.Windows.Forms.ComboBox();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.errNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPostanskiBr = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDrzava = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPostanskiBr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDrzava)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPostanskiBr
            // 
            this.lblPostanskiBr.AutoSize = true;
            this.lblPostanskiBr.Location = new System.Drawing.Point(12, 76);
            this.lblPostanskiBr.Name = "lblPostanskiBr";
            this.lblPostanskiBr.Size = new System.Drawing.Size(100, 20);
            this.lblPostanskiBr.TabIndex = 14;
            this.lblPostanskiBr.Text = "Postanski broj";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 20);
            this.lblNaziv.TabIndex = 13;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtPostanskiBr
            // 
            this.txtPostanskiBr.Location = new System.Drawing.Point(12, 99);
            this.txtPostanskiBr.Name = "txtPostanskiBr";
            this.txtPostanskiBr.Size = new System.Drawing.Size(241, 27);
            this.txtPostanskiBr.TabIndex = 12;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(241, 27);
            this.txtNaziv.TabIndex = 11;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(159, 198);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(94, 29);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cmbDrzave
            // 
            this.cmbDrzave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrzave.FormattingEnabled = true;
            this.cmbDrzave.Location = new System.Drawing.Point(12, 164);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(241, 28);
            this.cmbDrzave.TabIndex = 15;
            // 
            // lblDrzava
            // 
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.Location = new System.Drawing.Point(12, 141);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(55, 20);
            this.lblDrzava.TabIndex = 16;
            this.lblDrzava.Text = "Drzava";
            // 
            // errNaziv
            // 
            this.errNaziv.ContainerControl = this;
            // 
            // errPostanskiBr
            // 
            this.errPostanskiBr.ContainerControl = this;
            // 
            // errDrzava
            // 
            this.errDrzava.ContainerControl = this;
            // 
            // frmDetaljiGrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 252);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.cmbDrzave);
            this.Controls.Add(this.lblPostanskiBr);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtPostanskiBr);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDetaljiGrada";
            this.Text = "Detalji Grada";
            this.Load += new System.EventHandler(this.frmDetaljiGrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPostanskiBr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDrzava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPostanskiBr;
        private Label lblNaziv;
        private TextBox txtPostanskiBr;
        private TextBox txtNaziv;
        private Button btnSpremi;
        private ComboBox cmbDrzave;
        private Label lblDrzava;
        private ErrorProvider errNaziv;
        private ErrorProvider errPostanskiBr;
        private ErrorProvider errDrzava;
    }
}