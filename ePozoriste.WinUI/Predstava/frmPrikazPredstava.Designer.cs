﻿namespace ePozoriste.WinUI
{
    partial class frmPrikazPredstava
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvPredstave = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaPredstave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PrikazGlumaca = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Izvjestaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeTrajanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DodajGlumca = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVrste = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstave)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(847, 39);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(167, 29);
            this.btnPrikazi.TabIndex = 11;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvPredstave
            // 
            this.dgvPredstave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredstave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.VrstaPredstave,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn3,
            this.PrikazGlumaca,
            this.Izvjestaj});
            this.dgvPredstave.Location = new System.Drawing.Point(6, 26);
            this.dgvPredstave.Name = "dgvPredstave";
            this.dgvPredstave.RowHeadersWidth = 51;
            this.dgvPredstave.RowTemplate.Height = 29;
            this.dgvPredstave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstave.Size = new System.Drawing.Size(1181, 572);
            this.dgvPredstave.TabIndex = 10;
            this.dgvPredstave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredstave_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VrijemeTrajanje";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vrijeme trajanja";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // VrstaPredstave
            // 
            this.VrstaPredstave.DataPropertyName = "VrstaPredstave";
            this.VrstaPredstave.HeaderText = "Vrsta predstave";
            this.VrstaPredstave.MinimumWidth = 6;
            this.VrstaPredstave.Name = "VrstaPredstave";
            this.VrstaPredstave.ReadOnly = true;
            this.VrstaPredstave.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.HeaderText = "Uredi";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Uredi";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn2.HeaderText = "Obrisi";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Obrisi";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn3.HeaderText = "Dodaj glumca";
            this.dataGridViewButtonColumn3.MinimumWidth = 6;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.ReadOnly = true;
            this.dataGridViewButtonColumn3.Text = "Dodaj glumca";
            this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // PrikazGlumaca
            // 
            this.PrikazGlumaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrikazGlumaca.HeaderText = "Prikaz glumaca";
            this.PrikazGlumaca.MinimumWidth = 6;
            this.PrikazGlumaca.Name = "PrikazGlumaca";
            this.PrikazGlumaca.ReadOnly = true;
            this.PrikazGlumaca.Text = "Prikaz glumaca";
            this.PrikazGlumaca.UseColumnTextForButtonValue = true;
            // 
            // Izvjestaj
            // 
            this.Izvjestaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Izvjestaj.HeaderText = "Izvjestaj";
            this.Izvjestaj.MinimumWidth = 6;
            this.Izvjestaj.Name = "Izvjestaj";
            this.Izvjestaj.ReadOnly = true;
            this.Izvjestaj.Text = "Izvjestaj";
            this.Izvjestaj.UseColumnTextForButtonValue = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1020, 39);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(171, 29);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Nova predstava";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 41);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(377, 27);
            this.txtPretraga.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "PredstavaId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
            // 
            // VrijemeTrajanja
            // 
            this.VrijemeTrajanja.DataPropertyName = "VrijemeTrajanje";
            this.VrijemeTrajanja.HeaderText = "Vrijeme trajanja";
            this.VrijemeTrajanja.MinimumWidth = 6;
            this.VrijemeTrajanja.Name = "VrijemeTrajanja";
            this.VrijemeTrajanja.ReadOnly = true;
            this.VrijemeTrajanja.Width = 125;
            // 
            // Uredi
            // 
            this.Uredi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            // 
            // Obrisi
            // 
            this.Obrisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // DodajGlumca
            // 
            this.DodajGlumca.HeaderText = "Dodaj glumca";
            this.DodajGlumca.MinimumWidth = 6;
            this.DodajGlumca.Name = "DodajGlumca";
            this.DodajGlumca.Text = "Dodaj glumca";
            this.DodajGlumca.UseColumnTextForButtonValue = true;
            this.DodajGlumca.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbVrste);
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga predstava";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPredstave);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 618);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predstave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vrsta predstave:";
            // 
            // cmbVrste
            // 
            this.cmbVrste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrste.FormattingEnabled = true;
            this.cmbVrste.Location = new System.Drawing.Point(400, 39);
            this.cmbVrste.Name = "cmbVrste";
            this.cmbVrste.Size = new System.Drawing.Size(256, 28);
            this.cmbVrste.TabIndex = 15;
            // 
            // frmPrikazPredstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 746);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazPredstava";
            this.Text = "Prikaz predstava";
            this.Load += new System.EventHandler(this.frmPrikazPredstava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPrikazi;
        private DataGridView dgvPredstave;
        private Button btnDodaj;
        private TextBox txtPretraga;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn VrijemeTrajanja;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private DataGridViewButtonColumn DodajGlumca;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn VrstaPredstave;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn PrikazGlumaca;
        private DataGridViewButtonColumn Izvjestaj;
        private Label label1;
        private ComboBox cmbVrste;
    }
}