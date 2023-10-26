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
        private Obavijest _obavijest;


        public frmDodajObavijest(Obavijest obavijest = null)
        {
            InitializeComponent();
            _obavijest = obavijest;
            if(_obavijest == null)
                UcitajKategorije();
        }

        private async Task UcitajKategorije()
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
                    await UcitajKategorije();
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
                    ObavijestInsertRequest obavijestInsertRequest = new ObavijestInsertRequest
                    {
                        Naslov = txtNaslov.Text,
                        Podnaslov = txtPodnaslov.Text,
                        Sadrzaj = txtSadrzaj.Text,
                        ObavijestKategorijaId = (int)cmbKategorije.SelectedValue,
                        Slika = pbSlika.Image != null ? ImageHelper.ConvertImageToString(pbSlika.Image) : null,
                        DatumKreiranja = DateTime.Now.Date,
                        KorisnikId = APIService.LogiraniKorisnikId
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbSlika.Image = Image.FromFile(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Možete učitati samo slike", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
