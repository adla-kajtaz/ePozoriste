using ePozoriste.Model;
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
    public partial class frmPrikazVrstaPredstave : Form
    {
        APIService _vrstaPredstaveService { get; set; } = new APIService("VrstaPredstave");
        public frmPrikazVrstaPredstave()
        {
            InitializeComponent();
            dgvVrstePredstave.AutoGenerateColumns = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajVrstuPredstave frmDodajVrstuPredstave = new frmDodajVrstuPredstave();
            if (frmDodajVrstuPredstave.ShowDialog() == DialogResult.OK)
            {
                dgvVrstePredstave.DataSource = null;
                frmPrikazVrstaPredstave_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            BaseSearchObject vrstaPredstaveSearchRequest = new BaseSearchObject
            {
                Tekst = txtPretraga.Text
            };
            dgvVrstePredstave.DataSource = await _vrstaPredstaveService.Get<List<VrstaPredstave>>(vrstaPredstaveSearchRequest);
        }

        private async void frmPrikazVrstaPredstave_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new BaseSearchObject
                {

                };
                dgvVrstePredstave.DataSource = await _vrstaPredstaveService.Get<List<VrstaPredstave>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvVrstePredstave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vrstePredstave = dgvVrstePredstave.SelectedRows[0].DataBoundItem as VrstaPredstave;
            if (e.ColumnIndex == 3)
            {
                await _vrstaPredstaveService.Delete<VrstaPredstave>(vrstePredstave.VrstaPredstaveId);
                dgvVrstePredstave.DataSource = null;
                frmPrikazVrstaPredstave_Load(sender, e);
            }
            else if (e.ColumnIndex == 2)
            {
                frmDodajVrstuPredstave frmDodajVrstuPredstave = new frmDodajVrstuPredstave(vrstePredstave);
                if (frmDodajVrstuPredstave.ShowDialog() == DialogResult.OK)
                {
                    dgvVrstePredstave.DataSource = null;
                    frmPrikazVrstaPredstave_Load(sender, e);
                }
            }
        }
    }
}
