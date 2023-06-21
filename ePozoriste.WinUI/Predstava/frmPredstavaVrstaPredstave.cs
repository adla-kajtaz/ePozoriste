using ePozoriste.Model;
using ePozoriste.Model.Requests;
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
                if (ValidanUnos())
                {
                    PredstavaVrstaPredstaveInsertRequest predstavaVrstaPredstaveInsertRequest = new PredstavaVrstaPredstaveInsertRequest
                    {
                        PredstavaId = _predstava.PredstavaId,
                        VrstaPredstaveId = (int)cmbVrstePredstave.SelectedValue
                    };

                    var predstavaVrstaPredstave = await _predstavaVrstaPredstaveService.Insert<PredstavaVrstaPredstave>(predstavaVrstaPredstaveInsertRequest);

                    MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                      Resursi.Get(Kljucevi.Informacija),
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resursi.Get(Kljucevi.Greska),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(cmbVrstePredstave, err, Kljucevi.ObaveznaVrijednost);
        }
    }
}
