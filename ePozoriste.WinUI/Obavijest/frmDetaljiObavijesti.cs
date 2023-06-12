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
    public partial class frmDetaljiObavijesti : Form
    {
        APIService _obavijestKategorijaService { get; set; } = new APIService("ObavijestKategorija");
        APIService _obavijestService { get; set; } = new APIService("Obavijest");
        private Obavijest _obavijest;

        public frmDetaljiObavijesti(Obavijest obavijest = null)
        {
            InitializeComponent();
            _obavijest = obavijest;
            UcitajKategorije();
        }

        private async void frmDetaljiObavijesti_Load(object sender, EventArgs e)
        {
            try
            {
                if (_obavijest != null)
                {
                    txtNaslov.Text = _obavijest.Naslov;
                    txtPodnaslov.Text = _obavijest.Podnaslov;
                    txtSadrzaj.Text = _obavijest.Sadrzaj;
                    cmbKategorije.SelectedValue = _obavijest.ObavijestKategorijaId;
                    // pbSlika
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            //ne radi kako treba
           /*
            try
            {
                ObavijestInsertRequest obavijestInsertRequest = new ObavijestInsertRequest
                {
                    //Naslov = txtNaslov.Text,
                    //Podnaslov = txtPodnaslov.Text,
                    //Sadrzaj = txtSadrzaj.Text,
                    //ObavijestKategorijaId = (int)cmbKategorije.SelectedValue,
                    //DatumKreiranja = DateTime.Now,
                    //KorisnikId = 1
                    // ispraviti za korisnika
                    // Slika 
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
            }*/
        }
    }
}
