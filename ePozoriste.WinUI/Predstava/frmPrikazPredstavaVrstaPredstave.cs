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
    public partial class frmPrikazPredstavaVrstaPredstave : Form
    {
        APIService _predstavaVrstaPredstaveService { get; set; } = new APIService("PredstavaVrstaPredstave");
        private Predstava _predstava;

        public frmPrikazPredstavaVrstaPredstave(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
            txtNazivPredstave.Text = _predstava.Naziv;
            dgvVrstePredstave.AutoGenerateColumns = false;
        }

        private async void frmPrikazPredstavaGlumac_Load(object sender, EventArgs e)
        {
            try
            {
                PredstavaVrstaPredstaveSearchObject predstavaVrstaPredstaveSearchObject = new PredstavaVrstaPredstaveSearchObject
                {
                    PredstavaId = _predstava.PredstavaId
                };
                dgvVrstePredstave.DataSource = await _predstavaVrstaPredstaveService.Get<List<PredstavaVrstaPredstave>>(predstavaVrstaPredstaveSearchObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvGlumci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var predstavaVrsta = dgvVrstePredstave.SelectedRows[0].DataBoundItem as PredstavaVrstaPredstave;
            if (e.ColumnIndex == 1)
            {
                //var obrisanaDrazva=
                await _predstavaVrstaPredstaveService.Delete<PredstavaGlumac>(predstavaVrsta.PredstavaVpid);
                //if (obrisanaDrazva != null){
                dgvVrstePredstave.DataSource = null;
                frmPrikazPredstavaGlumac_Load(sender, e);
            }
        }
    }
}
