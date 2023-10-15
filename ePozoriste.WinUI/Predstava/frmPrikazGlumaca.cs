using ePozoriste.Model;
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
    public partial class frmPrikazGlumaca : Form
    {
        APIService _glumacService { get; set; } = new APIService("Glumac");
        public frmPrikazGlumaca()
        {
            InitializeComponent();
            dgvGlumci.AutoGenerateColumns = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajGlumca frmDodajGlumca = new frmDodajGlumca();
            if (frmDodajGlumca.ShowDialog() == DialogResult.OK)
            {
                dgvGlumci.DataSource = null;
                frmPrikazGlumaca_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            BaseSearchObject glumacSearchRequest = new BaseSearchObject
            {
                Tekst = txtPretraga.Text
            };
            dgvGlumci.DataSource = await _glumacService.Get<List<Glumac>>(glumacSearchRequest);
        }

        private async void frmPrikazGlumaca_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new BaseSearchObject
                {

                };
                dgvGlumci.DataSource = await _glumacService.Get<List<Glumac>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvGlumci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var glumac = dgvGlumci.SelectedRows[0].DataBoundItem as Glumac;
            if (e.ColumnIndex == 3)
            {
                var _glumac = await _glumacService.Delete<Glumac>(glumac.GlumacId);
                if (_glumac == null)
                    MessageBox.Show(Resursi.Get(Kljucevi.NeMozeteObrisati),
                                          Resursi.Get(Kljucevi.Informacija),
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                dgvGlumci.DataSource = null;
                frmPrikazGlumaca_Load(sender, e);
            }
            else if (e.ColumnIndex == 2)
            {
                frmDodajGlumca frmDodajGlumca = new frmDodajGlumca(glumac);
                if (frmDodajGlumca.ShowDialog() == DialogResult.OK)
                {
                    dgvGlumci.DataSource = null;
                    frmPrikazGlumaca_Load(sender, e);
                }
            }
        }
    }
}
