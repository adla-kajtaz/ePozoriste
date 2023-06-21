namespace ePozoriste.WinUI
{
    partial class frmDodajSalu
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
            this.lblBrSjedistaPoRedu = new System.Windows.Forms.Label();
            this.txtBrSjedistaPoRedu = new System.Windows.Forms.TextBox();
            this.lblBrRedova = new System.Windows.Forms.Label();
            this.txtBrRedova = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lbBrSjedista = new System.Windows.Forms.Label();
            this.txtBrSjedista = new System.Windows.Forms.TextBox();
            this.errNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSjedista = new System.Windows.Forms.ErrorProvider(this.components);
            this.errBrojRedova = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSjPoRedu = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSjedista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBrojRedova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSjPoRedu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrSjedistaPoRedu
            // 
            this.lblBrSjedistaPoRedu.AutoSize = true;
            this.lblBrSjedistaPoRedu.Location = new System.Drawing.Point(292, 62);
            this.lblBrSjedistaPoRedu.Name = "lblBrSjedistaPoRedu";
            this.lblBrSjedistaPoRedu.Size = new System.Drawing.Size(146, 20);
            this.lblBrSjedistaPoRedu.TabIndex = 38;
            this.lblBrSjedistaPoRedu.Text = "Broj sjedista po redu";
            // 
            // txtBrSjedistaPoRedu
            // 
            this.txtBrSjedistaPoRedu.Location = new System.Drawing.Point(292, 85);
            this.txtBrSjedistaPoRedu.Name = "txtBrSjedistaPoRedu";
            this.txtBrSjedistaPoRedu.Size = new System.Drawing.Size(241, 27);
            this.txtBrSjedistaPoRedu.TabIndex = 37;
            // 
            // lblBrRedova
            // 
            this.lblBrRedova.AutoSize = true;
            this.lblBrRedova.Location = new System.Drawing.Point(292, 9);
            this.lblBrRedova.Name = "lblBrRedova";
            this.lblBrRedova.Size = new System.Drawing.Size(86, 20);
            this.lblBrRedova.TabIndex = 36;
            this.lblBrRedova.Text = "Broj redova";
            // 
            // txtBrRedova
            // 
            this.txtBrRedova.Location = new System.Drawing.Point(292, 32);
            this.txtBrRedova.Name = "txtBrRedova";
            this.txtBrRedova.Size = new System.Drawing.Size(241, 27);
            this.txtBrRedova.TabIndex = 35;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 20);
            this.lblNaziv.TabIndex = 30;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(241, 27);
            this.txtNaziv.TabIndex = 29;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 137);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(521, 29);
            this.btnSpremi.TabIndex = 28;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lbBrSjedista
            // 
            this.lbBrSjedista.AutoSize = true;
            this.lbBrSjedista.Location = new System.Drawing.Point(12, 62);
            this.lbBrSjedista.Name = "lbBrSjedista";
            this.lbBrSjedista.Size = new System.Drawing.Size(90, 20);
            this.lbBrSjedista.TabIndex = 40;
            this.lbBrSjedista.Text = "Broj sjedista";
            // 
            // txtBrSjedista
            // 
            this.txtBrSjedista.Location = new System.Drawing.Point(12, 85);
            this.txtBrSjedista.Name = "txtBrSjedista";
            this.txtBrSjedista.Size = new System.Drawing.Size(241, 27);
            this.txtBrSjedista.TabIndex = 39;
            // 
            // errNaziv
            // 
            this.errNaziv.ContainerControl = this;
            // 
            // errSjedista
            // 
            this.errSjedista.ContainerControl = this;
            // 
            // errBrojRedova
            // 
            this.errBrojRedova.ContainerControl = this;
            // 
            // errSjPoRedu
            // 
            this.errSjPoRedu.ContainerControl = this;
            // 
            // frmDodajSalu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 195);
            this.Controls.Add(this.lbBrSjedista);
            this.Controls.Add(this.txtBrSjedista);
            this.Controls.Add(this.lblBrSjedistaPoRedu);
            this.Controls.Add(this.txtBrSjedistaPoRedu);
            this.Controls.Add(this.lblBrRedova);
            this.Controls.Add(this.txtBrRedova);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDodajSalu";
            this.Text = "Dodaj Salu";
            this.Load += new System.EventHandler(this.frmDodajSalu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSjedista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBrojRedova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSjPoRedu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBrSjedistaPoRedu;
        private TextBox txtBrSjedistaPoRedu;
        private Label lblBrRedova;
        private TextBox txtBrRedova;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private Button btnSpremi;
        private Label lbBrSjedista;
        private TextBox txtBrSjedista;
        private ErrorProvider errNaziv;
        private ErrorProvider errSjedista;
        private ErrorProvider errBrojRedova;
        private ErrorProvider errSjPoRedu;
    }
}