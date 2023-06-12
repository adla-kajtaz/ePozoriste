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
    public partial class frmDodavanjeTermina : Form
    {
        APIService _terminService { get; set; } = new APIService("Termin");
        APIService _predstavaService { get; set; } = new APIService("Predstava");
        APIService _salaService { get; set; } = new APIService("Sala");
        private Termin _termin;

        public frmDodavanjeTermina(Termin termin = null)
        {
            InitializeComponent();
            _termin = termin;
            UcitajSale();
            UcitajPozorista();
        }

        private async void UcitajSale()
        {
            try
            {
                var sale = await _salaService.Get<List<Sala>>() as IList<Sala>;
                cmbSale.DataSource = sale;
                cmbSale.DisplayMember = "Naziv";
                cmbSale.ValueMember = "SalaId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajPozorista()
        {
            try
            {
                var predstave = await _predstavaService.Get<List<Predstava>>() as IList<Predstava>;
                cmbPredstave.DataSource = predstave;
                cmbPredstave.DisplayMember = "Naziv";
                cmbPredstave.ValueMember = "PredstavaId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void frmDodavanjeTermina_Load(object sender, EventArgs e)
        {
            try
            {
                if (_termin != null)
                {
                    cmbPredstave.SelectedValue = _termin.PredstavaId;
                    cmbSale.SelectedValue = _termin.SalaId;
                    txtCijenaKarte.Text = _termin.CijenaKarte.ToString();
                    dtpDatum.Value = _termin.DatumVrijemeOdrzavanja;
                    cbPredpremijera.Checked = _termin.Predpremijera;
                    cbPremijera.Checked = _termin.Premijera;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                TerminInsertRequest terminInsertRequest = new TerminInsertRequest
                {
                    PredstavaId = (int)cmbPredstave.SelectedValue,
                    SalaId = (int)cmbSale.SelectedValue,
                    CijenaKarte = Int32.Parse(txtCijenaKarte.Text),
                    DatumVrijemeOdrzavanja = dtpDatum.Value,
                    Predpremijera = cbPredpremijera.Checked,
                    Premijera = cbPremijera.Checked
                };

                if (_termin == null)
                {
                    var termin = await _terminService.Insert<Termin>(terminInsertRequest);
                    //nakon sto se uspjesno doda termin kreirati određenji broj karata, koliko je sjedista u sali
                }
                else
                {
                    var termin = await _terminService.Update<Termin>(_termin.TerminId, terminInsertRequest);
                }
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
