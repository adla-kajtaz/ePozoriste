﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ePozoriste.WinUI
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnDrzava_Click(object sender, EventArgs e)
        {
            frmPrikazDrzave frmPrikazDrzave = new frmPrikazDrzave();
            frmPrikazDrzave.Show();
        }

        private void btnObavijestKategorija_Click(object sender, EventArgs e)
        {
            frmPrikazKategorijeObavijesti frmPrikazKategorijeObavijesti =new frmPrikazKategorijeObavijesti();
            frmPrikazKategorijeObavijesti.Show(); 
        }

        private void btnGrad_Click(object sender, EventArgs e)
        {
            frmPrikazGradova frmPrikazGradova = new frmPrikazGradova();
            frmPrikazGradova.Show();
        }

        private void btnObavijest_Click(object sender, EventArgs e)
        {
            frmPrikazObavijesti frmPrikazObavijesti = new frmPrikazObavijesti();
            frmPrikazObavijesti.Show();
        }

        private void btnPozoriste_Click(object sender, EventArgs e)
        {
            frmPrikazPozorista frmPrikazPozorista = new frmPrikazPozorista();
            frmPrikazPozorista.Show();
        }
    }
}