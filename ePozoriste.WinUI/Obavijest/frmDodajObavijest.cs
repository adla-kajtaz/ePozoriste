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
            //dodati korisnika
            try
            {
                ObavijestInsertRequest obavijestInsertRequest = new ObavijestInsertRequest
                {
                    Naslov = txtNaslov.Text,
                    Podnaslov = txtPodnaslov.Text,
                    Sadrzaj = txtSadrzaj.Text,
                    ObavijestKategorijaId = (int)cmbKategorije.SelectedValue,
                    Slika = ImageHelper.ConvertImageToString(pbSlika.Image),
                    DatumKreiranja = DateTime.Now.Date,
                    KorisnikId = 1
                };

                if (_obavijest == null)
                {
                    var obavijest = await _obavijestService.Insert<Obavijest>(obavijestInsertRequest);
                }
                else
                {
                    var obavijest = await _obavijestService.Update<Obavijest>(_obavijest.ObavijestId, obavijestInsertRequest);
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

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
