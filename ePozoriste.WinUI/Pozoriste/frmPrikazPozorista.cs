﻿using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
using System;
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
    public partial class frmPrikazPozorista : Form
    {
        APIService _gradService { get; set; } = new APIService("Grad");
        APIService _pozoristeService { get; set; } = new APIService("Pozoriste");
        public frmPrikazPozorista()
        {
            InitializeComponent();
            dgvPozorista.AutoGenerateColumns = false;
        }

        private async void frmPrikazPozorista_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new PozoristeSearchObject
                {

                };
                dgvPozorista.DataSource = await _pozoristeService.Get<List<Pozoriste>>();
                UcitajGradove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajGradove()
        {
            try
            {
                var gradovi = await _gradService.Get<List<Grad>>() as IList<Grad>;
                cmbGradovi.DataSource = gradovi;
                cmbGradovi.DisplayMember = "Naziv";
                cmbGradovi.ValueMember = "GradId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajPozoriste frmDodajPozoriste = new frmDodajPozoriste();
            if (frmDodajPozoriste.ShowDialog() == DialogResult.OK)
            {
                dgvPozorista.DataSource = null;
                frmPrikazPozorista_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            PozoristeSearchObject pozoristeSearchRequest = new PozoristeSearchObject
            {
                Tekst = txtPretraga.Text,
                GradId = (int)cmbGradovi.SelectedValue
            };
            dgvPozorista.DataSource = await _pozoristeService.Get<List<Pozoriste>>(pozoristeSearchRequest);
        }

        private async void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var pozoriste = dgvPozorista.SelectedRows[0].DataBoundItem as Pozoriste;
            if (e.ColumnIndex == 10)
            {
                //var obrisanoPozoriste=
                await _pozoristeService.Delete<Pozoriste>(pozoriste.PozoristeId);
                //if (obrisanoPozoriste != null){
                dgvPozorista.DataSource = null;
                frmPrikazPozorista_Load(sender, e);
                /*}
                else
                {
                    MessageBox.Show("Greska");
                }*/
            }
            else if (e.ColumnIndex == 9)
            {
                frmDodajPozoriste frmDodajPozoriste = new frmDodajPozoriste(pozoriste);
                if (frmDodajPozoriste.ShowDialog() == DialogResult.OK)
                {
                    dgvPozorista.DataSource = null;
                    frmPrikazPozorista_Load(sender, e);
                }
            }
        }
    }
}
