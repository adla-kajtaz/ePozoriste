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
    public partial class frmPrikazKategorijeObavijesti : Form
    {
        APIService _obavijestKategorijaService { get; set; } = new APIService("ObavijestKategorija");
        public frmPrikazKategorijeObavijesti()
        {
            InitializeComponent();
            dgvKategorijeObavijesti.AutoGenerateColumns = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajKatergorijuObavijesti frmDetalji = new frmDodajKatergorijuObavijesti();
            if (frmDetalji.ShowDialog() == DialogResult.OK)
            {
                dgvKategorijeObavijesti.DataSource = null;
                frmPrikazKategorijeObavijesti_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            BaseSearchObject obavijestKategorijaSearchRequest = new BaseSearchObject
            {
                Tekst = txtPretraga.Text
            };
            dgvKategorijeObavijesti.DataSource = await _obavijestKategorijaService.Get<List<ObavijestKategorija>>(obavijestKategorijaSearchRequest);
        }

        private async void frmPrikazKategorijeObavijesti_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new BaseSearchObject
                {

                };
                dgvKategorijeObavijesti.DataSource = await _obavijestKategorijaService.Get<List<ObavijestKategorija>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvKategorijeObavijesti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obavijestKategorija = dgvKategorijeObavijesti.SelectedRows[0].DataBoundItem as ObavijestKategorija;
            if (e.ColumnIndex == 3)
            {
                //var obrisanaKategorija=
                await _obavijestKategorijaService.Delete<ObavijestKategorija>(obavijestKategorija.ObavijestKategorijaId);
                //if (obrisanaKategorija != null){
                dgvKategorijeObavijesti.DataSource = null;
                frmPrikazKategorijeObavijesti_Load(sender, e);
                /*}
                else
                {
                    MessageBox.Show("Greska");
                }*/
            }
            else if (e.ColumnIndex == 2)
            {
                frmDodajKatergorijuObavijesti frmDetalji = new frmDodajKatergorijuObavijesti(obavijestKategorija);
                if (frmDetalji.ShowDialog() == DialogResult.OK)
                {
                    dgvKategorijeObavijesti.DataSource = null;
                    frmPrikazKategorijeObavijesti_Load(sender, e);
                }
            }
        }
    }
}