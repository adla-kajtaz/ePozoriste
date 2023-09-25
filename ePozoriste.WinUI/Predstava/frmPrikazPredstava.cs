using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
using ePozoriste.WinUI.Reports;
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
    public partial class frmPrikazPredstava : Form
    {
        APIService _predstavaService { get; set; } = new APIService("Predstava");
        public frmPrikazPredstava()
        {
            InitializeComponent();
            dgvPredstave.AutoGenerateColumns = false;
        }

        private async void frmPrikazPredstava_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new BaseSearchObject
                {

                };
                dgvPredstave.DataSource = await _predstavaService.Get<List<Predstava>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajPredstavu frmDodajPredstavu = new frmDodajPredstavu();
            if (frmDodajPredstavu.ShowDialog() == DialogResult.OK)
            {
                dgvPredstave.DataSource = null;
                frmPrikazPredstava_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            BaseSearchObject predstavaSearchObject = new BaseSearchObject
            {
                Tekst = txtPretraga.Text
            };
            dgvPredstave.DataSource = await _predstavaService.Get<List<Predstava>>(predstavaSearchObject);
        }

        private async void dgvPredstave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var predstava = dgvPredstave.SelectedRows[0].DataBoundItem as Predstava;
            if (e.ColumnIndex == 3)
            {
                await _predstavaService.Delete<Predstava>(predstava.PredstavaId);
                dgvPredstave.DataSource = null;
                frmPrikazPredstava_Load(sender, e);
              
            }
            else if (e.ColumnIndex == 2)
            {
                frmDodajPredstavu frmDodajPredstavu = new frmDodajPredstavu(predstava);
                if (frmDodajPredstavu.ShowDialog() == DialogResult.OK)
                {
                    dgvPredstave.DataSource = null;
                    frmPrikazPredstava_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 4)
            {
                frmGlumacPredstava frmGlumacPredstava = new frmGlumacPredstava(predstava);
                if (frmGlumacPredstava.ShowDialog() == DialogResult.OK)
                {
                    dgvPredstave.DataSource = null;
                    frmPrikazPredstava_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 5)
            {
                frmPrikazPredstavaGlumac frmPrikazPredstavaGlumac = new frmPrikazPredstavaGlumac(predstava);
                if (frmPrikazPredstavaGlumac.ShowDialog() == DialogResult.OK)
                {
                    dgvPredstave.DataSource = null;
                    frmPrikazPredstava_Load(sender, e);
                }
            }
            else if(e.ColumnIndex == 6)
            {
                frmPredstavaVrstaPredstave frmPredstavaVrstaPredstave = new frmPredstavaVrstaPredstave(predstava);
                if (frmPredstavaVrstaPredstave.ShowDialog() == DialogResult.OK)
                {
                    dgvPredstave.DataSource = null;
                    frmPrikazPredstava_Load(sender, e);
                }

            }
            else if (e.ColumnIndex == 7)
            {
                frmPrikazPredstavaVrstaPredstave frmPrikazPredstavaVrstaPredstave = new frmPrikazPredstavaVrstaPredstave(predstava);
                if (frmPrikazPredstavaVrstaPredstave.ShowDialog() == DialogResult.OK)
                {
                    dgvPredstave.DataSource = null;
                    frmPrikazPredstava_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 8)
            {
                frmZaradaPoPredstavi frmZaradaPoPredstavi = new frmZaradaPoPredstavi(predstava);
                if (frmZaradaPoPredstavi.ShowDialog() == DialogResult.OK)
                {
                    dgvPredstave.DataSource = null;
                    frmPrikazPredstava_Load(sender, e);
                }
            }
        }
    }
}
