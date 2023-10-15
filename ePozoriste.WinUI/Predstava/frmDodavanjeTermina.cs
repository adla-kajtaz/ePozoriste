using ePozoriste.Model;
using ePozoriste.Model.Requests;
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
    public partial class frmDodavanjeTermina : Form
    {
        APIService _terminService { get; set; } = new APIService("Termin");
        APIService _predstavaService { get; set; } = new APIService("Predstava");
        APIService _salaService { get; set; } = new APIService("Sala");
        APIService _kartaService { get; set; } = new APIService("Karta");

        private Termin _termin;
        private Sala _sala;

        public frmDodavanjeTermina(Sala sala,Termin termin = null)
        {
            InitializeComponent();
            _termin = termin;
            _sala = sala;
            txtSala.Text = _sala.Naziv;
            UcitajPredstave();
        }

        private async void UcitajPredstave()
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
                    txtCijenaKarte.Text = _termin.CijenaKarte.ToString();
                    dtpDatum.Value = _termin.DatumOdrzavanja;
                    txtVrijemeOdrzavanja.Text = _termin.VrijemeOdrzavanja;
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
                if (ValidanUnos())
                {
                    TerminInsertRequest terminInsertRequest = new TerminInsertRequest
                    {
                        PredstavaId = (int)cmbPredstave.SelectedValue,
                        SalaId = _sala.SalaId,
                        CijenaKarte = Int32.Parse(txtCijenaKarte.Text),
                        DatumOdrzavanja = dtpDatum.Value.Date,
                        VrijemeOdrzavanja = txtVrijemeOdrzavanja.Text,
                        Predpremijera = cbPredpremijera.Checked,
                        Premijera = cbPremijera.Checked
                    };
                    var searchRequest = new TerminSearchObject
                    {
                        SalaId = terminInsertRequest.SalaId,
                        DatumOdrzavanja = terminInsertRequest.DatumOdrzavanja
                    };
                    var termini = await _terminService.Get<List<Termin>>(searchRequest);
                    bool postoji = false;
                    foreach(Termin termin in termini)
                    {
                        if (termin.VrijemeOdrzavanja.ToLower().Contains(terminInsertRequest.VrijemeOdrzavanja.ToLower()))
                            postoji = true;
                    }

                    if (!postoji)
                    {

                        if (_termin == null)
                        {
                            var termin = await _terminService.Insert<Termin>(terminInsertRequest);

                            if (termin != null)
                            {
                                for (int i = 0; i < _sala.BrRedova; i++)
                                {
                                    var red = (char)(i + 65);
                                    for (int j = 0; j < _sala.BrSjedistaPoRedu; j++)
                                    {
                                        KartaInsertRequest kartaInsertRequest = new KartaInsertRequest
                                        {
                                            Aktivna = true,
                                            TerminId = termin.TerminId,
                                            BrojSjedista = j + 1,
                                            BrojReda = red.ToString(),
                                            Sjediste = $"{red.ToString()}{(j + 1).ToString()}"
                                        };

                                        var karta = await _kartaService.Insert<Karta>(kartaInsertRequest);
                                    }
                                }
                                MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                      Resursi.Get(Kljucevi.Informacija),
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            var termin = await _terminService.Update<Termin>(_termin.TerminId, terminInsertRequest);
                            MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoModifikovani),
                                      Resursi.Get(Kljucevi.Informacija),
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(Resursi.Get(Kljucevi.ZauzetaSala),
                                      Resursi.Get(Kljucevi.Informacija),
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }

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
            return Validator.ValidirajKontrolu(cmbPredstave, errPredstava, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtCijenaKarte,errCijena,Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtVrijemeOdrzavanja,errVrijeme,Kljucevi.ObaveznaVrijednost);;
        }
    }
}
