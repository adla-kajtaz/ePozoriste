namespace ePozoriste.WinUI
{
    partial class frmDodajPredstavu
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
            this.lblSadrzaj = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.pbSlikaPlakata = new System.Windows.Forms.PictureBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblVrijemeTrajanja = new System.Windows.Forms.Label();
            this.txtVrijemeTrajanja = new System.Windows.Forms.TextBox();
            this.lblRezija = new System.Windows.Forms.Label();
            this.txtRezija = new System.Windows.Forms.TextBox();
            this.lblScenografija = new System.Windows.Forms.Label();
            this.txtScenografija = new System.Windows.Forms.TextBox();
            this.lblKostimografija = new System.Windows.Forms.Label();
            this.txtKostimografija = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSadrzaj = new System.Windows.Forms.ErrorProvider(this.components);
            this.errVrijemeTrajanja = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGrad = new System.Windows.Forms.Label();
            this.cmbVrstePredstave = new System.Windows.Forms.ComboBox();
            this.errRezija = new System.Windows.Forms.ErrorProvider(this.components);
            this.errScenografija = new System.Windows.Forms.ErrorProvider(this.components);
            this.errKostimografija = new System.Windows.Forms.ErrorProvider(this.components);
            this.errVrsta = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaPlakata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSadrzaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errVrijemeTrajanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRezija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errScenografija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKostimografija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errVrsta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSadrzaj
            // 
            this.lblSadrzaj.AutoSize = true;
            this.lblSadrzaj.Location = new System.Drawing.Point(12, 62);
            this.lblSadrzaj.Name = "lblSadrzaj";
            this.lblSadrzaj.Size = new System.Drawing.Size(61, 20);
            this.lblSadrzaj.TabIndex = 23;
            this.lblSadrzaj.Text = "Sadržaj:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(12, 85);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSadrzaj.Size = new System.Drawing.Size(332, 171);
            this.txtSadrzaj.TabIndex = 22;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 9);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(49, 20);
            this.lblNaziv.TabIndex = 21;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(332, 27);
            this.txtNaziv.TabIndex = 20;
            // 
            // pbSlikaPlakata
            // 
            this.pbSlikaPlakata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaPlakata.Location = new System.Drawing.Point(389, 32);
            this.pbSlikaPlakata.Name = "pbSlikaPlakata";
            this.pbSlikaPlakata.Size = new System.Drawing.Size(146, 124);
            this.pbSlikaPlakata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaPlakata.TabIndex = 24;
            this.pbSlikaPlakata.TabStop = false;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(389, 9);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(43, 20);
            this.lblSlika.TabIndex = 25;
            this.lblSlika.Text = "Slika:";
            // 
            // lblVrijemeTrajanja
            // 
            this.lblVrijemeTrajanja.AutoSize = true;
            this.lblVrijemeTrajanja.Location = new System.Drawing.Point(12, 259);
            this.lblVrijemeTrajanja.Name = "lblVrijemeTrajanja";
            this.lblVrijemeTrajanja.Size = new System.Drawing.Size(155, 20);
            this.lblVrijemeTrajanja.TabIndex = 27;
            this.lblVrijemeTrajanja.Text = "Vrijeme trajanja (min):";
            // 
            // txtVrijemeTrajanja
            // 
            this.txtVrijemeTrajanja.Location = new System.Drawing.Point(12, 282);
            this.txtVrijemeTrajanja.Name = "txtVrijemeTrajanja";
            this.txtVrijemeTrajanja.Size = new System.Drawing.Size(332, 27);
            this.txtVrijemeTrajanja.TabIndex = 26;
            // 
            // lblRezija
            // 
            this.lblRezija.AutoSize = true;
            this.lblRezija.Location = new System.Drawing.Point(12, 312);
            this.lblRezija.Name = "lblRezija";
            this.lblRezija.Size = new System.Drawing.Size(52, 20);
            this.lblRezija.TabIndex = 29;
            this.lblRezija.Text = "Režija:";
            // 
            // txtRezija
            // 
            this.txtRezija.Location = new System.Drawing.Point(12, 335);
            this.txtRezija.Name = "txtRezija";
            this.txtRezija.Size = new System.Drawing.Size(332, 27);
            this.txtRezija.TabIndex = 28;
            // 
            // lblScenografija
            // 
            this.lblScenografija.AutoSize = true;
            this.lblScenografija.Location = new System.Drawing.Point(389, 159);
            this.lblScenografija.Name = "lblScenografija";
            this.lblScenografija.Size = new System.Drawing.Size(95, 20);
            this.lblScenografija.TabIndex = 31;
            this.lblScenografija.Text = "Scenografija:";
            // 
            // txtScenografija
            // 
            this.txtScenografija.Location = new System.Drawing.Point(389, 182);
            this.txtScenografija.Name = "txtScenografija";
            this.txtScenografija.Size = new System.Drawing.Size(332, 27);
            this.txtScenografija.TabIndex = 30;
            // 
            // lblKostimografija
            // 
            this.lblKostimografija.AutoSize = true;
            this.lblKostimografija.Location = new System.Drawing.Point(389, 212);
            this.lblKostimografija.Name = "lblKostimografija";
            this.lblKostimografija.Size = new System.Drawing.Size(110, 20);
            this.lblKostimografija.TabIndex = 33;
            this.lblKostimografija.Text = "Kostimografija:";
            // 
            // txtKostimografija
            // 
            this.txtKostimografija.Location = new System.Drawing.Point(389, 235);
            this.txtKostimografija.Name = "txtKostimografija";
            this.txtKostimografija.Size = new System.Drawing.Size(332, 27);
            this.txtKostimografija.TabIndex = 32;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(389, 333);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(332, 29);
            this.btnSpremi.TabIndex = 34;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(541, 127);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(137, 29);
            this.btnUcitajSliku.TabIndex = 35;
            this.btnUcitajSliku.Text = "Ucitaj sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errNaziv
            // 
            this.errNaziv.ContainerControl = this;
            // 
            // errSadrzaj
            // 
            this.errSadrzaj.ContainerControl = this;
            // 
            // errVrijemeTrajanja
            // 
            this.errVrijemeTrajanja.ContainerControl = this;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(389, 276);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(113, 20);
            this.lblGrad.TabIndex = 37;
            this.lblGrad.Text = "Vrsta predstave:";
            // 
            // cmbVrstePredstave
            // 
            this.cmbVrstePredstave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstePredstave.FormattingEnabled = true;
            this.cmbVrstePredstave.Location = new System.Drawing.Point(389, 299);
            this.cmbVrstePredstave.Name = "cmbVrstePredstave";
            this.cmbVrstePredstave.Size = new System.Drawing.Size(332, 28);
            this.cmbVrstePredstave.TabIndex = 36;
            // 
            // errRezija
            // 
            this.errRezija.ContainerControl = this;
            // 
            // errScenografija
            // 
            this.errScenografija.ContainerControl = this;
            // 
            // errKostimografija
            // 
            this.errKostimografija.ContainerControl = this;
            // 
            // errVrsta
            // 
            this.errVrsta.ContainerControl = this;
            // 
            // frmDodajPredstavu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 382);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.cmbVrstePredstave);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblKostimografija);
            this.Controls.Add(this.txtKostimografija);
            this.Controls.Add(this.lblScenografija);
            this.Controls.Add(this.txtScenografija);
            this.Controls.Add(this.lblRezija);
            this.Controls.Add(this.txtRezija);
            this.Controls.Add(this.lblVrijemeTrajanja);
            this.Controls.Add(this.txtVrijemeTrajanja);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.pbSlikaPlakata);
            this.Controls.Add(this.lblSadrzaj);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmDodajPredstavu";
            this.Text = "Predstava";
            this.Load += new System.EventHandler(this.frmDodajPredstavu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaPlakata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSadrzaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errVrijemeTrajanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRezija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errScenografija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKostimografija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errVrsta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSadrzaj;
        private TextBox txtSadrzaj;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private PictureBox pbSlikaPlakata;
        private Label lblSlika;
        private Label lblVrijemeTrajanja;
        private TextBox txtVrijemeTrajanja;
        private Label lblRezija;
        private TextBox txtRezija;
        private Label lblScenografija;
        private TextBox txtScenografija;
        private Label lblKostimografija;
        private TextBox txtKostimografija;
        private Button btnSpremi;
        private Button btnUcitajSliku;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errNaziv;
        private ErrorProvider errSadrzaj;
        private ErrorProvider errVrijemeTrajanja;
        private Label lblGrad;
        private ComboBox cmbVrstePredstave;
        private ErrorProvider errRezija;
        private ErrorProvider errScenografija;
        private ErrorProvider errKostimografija;
        private ErrorProvider errVrsta;
    }
}