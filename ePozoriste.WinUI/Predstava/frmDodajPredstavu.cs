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
    public partial class frmDodajPredstavu : Form
    {
        APIService _vrstaService { get; set; } = new APIService("VrstaPredstave");
        APIService _predstavaService { get; set; } = new APIService("Predstava");
        private Predstava _predstava;
        public  frmDodajPredstavu(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
            if (_predstava == null)
                UcitajVrste();
        }

        private async void frmDodajPredstavu_Load(object sender, EventArgs e)
        {
            try
            {
                if (_predstava != null)
                {
                    txtNaziv.Text = _predstava.Naziv;
                    txtSadrzaj.Text = _predstava.Sadrzaj;
                    txtVrijemeTrajanja.Text = _predstava.VrijemeTrajanje.ToString();
                    txtRezija.Text = _predstava.Rezija;
                    txtScenografija.Text = _predstava.Scenografija.ToString();
                    txtKostimografija.Text = _predstava.Kostimografija.ToString();
                    await UcitajVrste();
                    cmbVrstePredstave.SelectedValue = _predstava.VrstaPredstaveId;
                    if (_predstava.Slika != null)
                        pbSlikaPlakata.Image = ImageHelper.ConvertStringToImage(_predstava.Slika);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task UcitajVrste()
        {
            try
            {
                var vrste = await _vrstaService.Get<List<VrstaPredstave>>() as IList<VrstaPredstave>;
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
                    PredstavaInsertRequest predstavaInsertRequest = new PredstavaInsertRequest
                    {
                        Naziv = txtNaziv.Text,
                        Sadrzaj = txtSadrzaj.Text,
                        VrijemeTrajanje = Int32.Parse(txtVrijemeTrajanja.Text),
                        Rezija = txtRezija.Text,
                        Scenografija = txtScenografija.Text,
                        Kostimografija = txtKostimografija.Text,
                        VrstaPredstaveId = (int)cmbVrstePredstave.SelectedValue,
                        Slika = pbSlikaPlakata.Image != null ? ImageHelper.ConvertImageToString(pbSlikaPlakata.Image) : null
                    };

                    if (_predstava == null)
                    {
                        var predstava = await _predstavaService.Insert<Predstava>(predstavaInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                    else
                    {
                        var predstava = await _predstavaService.Update<Predstava>(_predstava.PredstavaId, predstavaInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoModifikovani),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
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

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlikaPlakata.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtNaziv, errNaziv, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSadrzaj, errSadrzaj, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtVrijemeTrajanja, errVrijemeTrajanja, Kljucevi.ObaveznaVrijednost);
        }
    }
}
