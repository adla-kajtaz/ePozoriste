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
    public partial class frmPrikazGradova : Form
    {
        APIService _gradService { get; set; } = new APIService("Grad");
        APIService _drzavaService { get; set; } = new APIService("Drzava");

        public frmPrikazGradova()
        {
            InitializeComponent();
            dgvGradovi.AutoGenerateColumns = false;
        }

        private async void frmPrikazGradova_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new GradSearchObject
                {

                };
                dgvGradovi.DataSource = await _gradService.Get<List<Grad>>();
                UcitajDrzave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajDrzave()
        {
            try
            {
                var drzava = await _drzavaService.Get<List<Drzava>>() as IList<Drzava>;
                cmbDrzave.DataSource = drzava;
                cmbDrzave.DisplayMember = "Naziv";
                cmbDrzave.ValueMember = "DrzavaId";
                cmbDrzave.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDetaljiGrada frmDetalji = new frmDetaljiGrada();
            if (frmDetalji.ShowDialog() == DialogResult.OK)
            {
                dgvGradovi.DataSource = null;
                frmPrikazGradova_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            GradSearchObject gradSearchRequest = new GradSearchObject();
            gradSearchRequest.Tekst = txtPretraga.Text;

            if (cmbDrzave.SelectedIndex != -1)
                gradSearchRequest.DrzavaId = (int)cmbDrzave.SelectedValue;
          
            dgvGradovi.DataSource = await _gradService.Get<List<Grad>>(gradSearchRequest);
        }

        private async void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grad = dgvGradovi.SelectedRows[0].DataBoundItem as Grad;
            if (e.ColumnIndex == 4)
            {
                var _grad = await _gradService.Delete<Grad>(grad.GradId);
                if (_grad == null)
                    MessageBox.Show(Resursi.Get(Kljucevi.NeMozeteObrisati),
                                          Resursi.Get(Kljucevi.Informacija),
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                dgvGradovi.DataSource = null;
                frmPrikazGradova_Load(sender, e);
            }
            else if (e.ColumnIndex == 3)
            {
                frmDetaljiGrada frmDetalji = new frmDetaljiGrada(grad);
                if (frmDetalji.ShowDialog() == DialogResult.OK)
                {
                    dgvGradovi.DataSource = null;
                    frmPrikazGradova_Load(sender, e);
                }
            }
        }
    }
}
