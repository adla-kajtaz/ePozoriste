namespace ePozoriste.WinUI
{
    partial class frmZarada
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
            this.cmbPredstave = new System.Windows.Forms.ComboBox();
            this.lblPredstava = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtBrKarata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZarada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPredstave
            // 
            this.cmbPredstave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredstave.FormattingEnabled = true;
            this.cmbPredstave.Location = new System.Drawing.Point(12, 37);
            this.cmbPredstave.Name = "cmbPredstave";
            this.cmbPredstave.Size = new System.Drawing.Size(250, 28);
            this.cmbPredstave.TabIndex = 20;
            // 
            // lblPredstava
            // 
            this.lblPredstava.AutoSize = true;
            this.lblPredstava.Location = new System.Drawing.Point(12, 9);
            this.lblPredstava.Name = "lblPredstava";
            this.lblPredstava.Size = new System.Drawing.Size(76, 20);
            this.lblPredstava.TabIndex = 22;
            this.lblPredstava.Text = "Predstava:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(268, 37);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(102, 29);
            this.btnPrikazi.TabIndex = 23;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtBrKarata
            // 
            this.txtBrKarata.Location = new System.Drawing.Point(268, 100);
            this.txtBrKarata.Name = "txtBrKarata";
            this.txtBrKarata.ReadOnly = true;
            this.txtBrKarata.Size = new System.Drawing.Size(100, 27);
            this.txtBrKarata.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ukupno prodanih karata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cijena po karti:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(268, 132);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(100, 27);
            this.txtCijena.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ukupna zarada:";
            // 
            // txtZarada
            // 
            this.txtZarada.Location = new System.Drawing.Point(268, 165);
            this.txtZarada.Name = "txtZarada";
            this.txtZarada.ReadOnly = true;
            this.txtZarada.Size = new System.Drawing.Size(100, 27);
            this.txtZarada.TabIndex = 28;
            // 
            // frmZarada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZarada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrKarata);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.lblPredstava);
            this.Controls.Add(this.cmbPredstave);
            this.Name = "frmZarada";
            this.Text = "Zarada";
            this.Load += new System.EventHandler(this.frmZarada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbPredstave;
        private Label lblPredstava;
        private Button btnPrikazi;
        private TextBox txtBrKarata;
        private Label label1;
        private Label label2;
        private TextBox txtCijena;
        private Label label3;
        private TextBox txtZarada;
    }
}