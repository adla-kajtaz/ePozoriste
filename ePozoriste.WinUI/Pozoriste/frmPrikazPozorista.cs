﻿using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
using ePozoriste.WinUI.Helper;
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

                var allOption = new Grad
                {
                    GradId = -1,
                    Naziv = "Svi"
                };

                gradovi.Insert(0, allOption);

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
            PozoristeSearchObject pozoristeSearchRequest = new PozoristeSearchObject();
            pozoristeSearchRequest.Tekst = txtPretraga.Text;

            if ((int)cmbGradovi.SelectedValue != -1)
                pozoristeSearchRequest.GradId = (int)cmbGradovi.SelectedValue;

            dgvPozorista.DataSource = await _pozoristeService.Get<List<Pozoriste>>(pozoristeSearchRequest);
        }

        private async void dgvPozorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var pozoriste = dgvPozorista.SelectedRows[0].DataBoundItem as Pozoriste;
            if (e.ColumnIndex == 8)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovo pozorište? Ne možete poništiti ovu radnju!", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;
                if (result == DialogResult.Yes)
                {
                    var _pozoriste = await _pozoristeService.Delete<Pozoriste>(pozoriste.PozoristeId);
                    if (_pozoriste == null)
                        MessageBox.Show("Ne možete obrisati pozorište jer postoje sale u njemu!",
                                              Resursi.Get(Kljucevi.Informacija),
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
                    dgvPozorista.DataSource = null;
                    frmPrikazPozorista_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 7)
            {
                frmDodajPozoriste frmDodajPozoriste = new frmDodajPozoriste(pozoriste);
                if (frmDodajPozoriste.ShowDialog() == DialogResult.OK)
                {
                    dgvPozorista.DataSource = null;
                    frmPrikazPozorista_Load(sender, e);
                }
            }
            else if(e.ColumnIndex == 9)
            {
                frmPrikazSala frmPrikazSala = new frmPrikazSala(pozoriste.PozoristeId);
                if (frmPrikazSala.ShowDialog() == DialogResult.OK)
                {
                    dgvPozorista.DataSource = null;
                    frmPrikazPozorista_Load(sender, e);
                }
            }
        }
    }
}
