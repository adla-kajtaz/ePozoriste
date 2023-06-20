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
    public partial class frmDodajObavijest : Form
    {
        APIService _obavijestKategorijaService { get; set; } = new APIService("ObavijestKategorija");
        APIService _obavijestService { get; set; } = new APIService("Obavijest");
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private Obavijest _obavijest;


        public frmDodajObavijest(Obavijest obavijest = null)
        {
            InitializeComponent();
            _obavijest = obavijest;
            UcitajKategorije();
        }

        private async void UcitajKategorije()
        {
            try
            {
                var kategorije = await _obavijestKategorijaService.Get<List<ObavijestKategorija>>() as IList<ObavijestKategorija>;
                cmbKategorije.DataSource = kategorije;
                cmbKategorije.DisplayMember = "Naziv";
                cmbKategorije.ValueMember = "ObavijestKategorijaId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void frmDodajObavijest_Load(object sender, EventArgs e)
        {
            try
            {
                if (_obavijest != null)
                {
                    txtNaslov.Text = _obavijest.Naslov;
                    txtPodnaslov.Text = _obavijest.Podnaslov;
                    txtSadrzaj.Text = _obavijest.Sadrzaj;
                    cmbKategorije.SelectedValue = _obavijest.ObavijestKategorijaId;
                    if (_obavijest.Slika != null)
                        pbSlika.Image = ImageHelper.ConvertStringToImage(_obavijest.Slika);
                }
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
                    var korisnici = await _korisnikService.Get<List<Korisnik>>();
                    var korisnik = korisnici.First(x => x.KorisnickoIme == APIService.KorisnickoIme);
                    ObavijestInsertRequest obavijestInsertRequest = new ObavijestInsertRequest
                    {
                        Naslov = txtNaslov.Text,
                        Podnaslov = txtPodnaslov.Text,
                        Sadrzaj = txtSadrzaj.Text,
                        ObavijestKategorijaId = (int)cmbKategorije.SelectedValue,
                        Slika = ImageHelper.ConvertImageToString(pbSlika.Image),
                        DatumKreiranja = DateTime.Now.Date,
                        KorisnikId = korisnik.KorisnikId
                    };

                    if (_obavijest == null)
                    {
                        var obavijest = await _obavijestService.Insert<Obavijest>(obavijestInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                    else
                    {
                        var obavijest = await _obavijestService.Update<Obavijest>(_obavijest.ObavijestId, obavijestInsertRequest);
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

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtNaslov, errNaslov, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPodnaslov, errPodnaslov, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSadrzaj, errSadrzaj, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlika, errSlika, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbKategorije, errKategorija, Kljucevi.ObaveznaVrijednost);
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
