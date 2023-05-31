using ePozoriste.Model;
using ePozoriste.Model.Requests;
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
    public partial class frmPredstavaVrstaPredstave : Form
    {
        APIService _predstavaVrstaPredstaveService { get; set; } = new APIService("PredstavaVrstaPredstave");
        APIService _vrstaPredstaveService { get; set; } = new APIService("VrstaPredstave");
        private Predstava _predstava;
        public frmPredstavaVrstaPredstave(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
            txtNazivPredstave.Text = _predstava.Naziv;
            UcitajVrstePredstava();
        }

        private async void UcitajVrstePredstava()
        {
            try
            {
                var vrste = await _vrstaPredstaveService.Get<List<VrstaPredstave>>() as IList<VrstaPredstave>;
                cmbVrstePredstave.DataSource = vrste;
                cmbVrstePredstave.DisplayMember = "Naziv";
                cmbVrstePredstave.ValueMember = "VrstaPredstaveId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                PredstavaVrstaPredstaveInsertRequest predstavaVrstaPredstaveInsertRequest = new PredstavaVrstaPredstaveInsertRequest
                {
                    PredstavaId = _predstava.PredstavaId,
                    VrstaPredstaveId = (int)cmbVrstePredstave.SelectedValue
                };

                var predstavaVrstaPredstave = await _predstavaVrstaPredstaveService.Insert<PredstavaVrstaPredstave>(predstavaVrstaPredstaveInsertRequest);

                MessageBox.Show("Uspjesno sacuvano");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska");
            }
        }
    }
}
