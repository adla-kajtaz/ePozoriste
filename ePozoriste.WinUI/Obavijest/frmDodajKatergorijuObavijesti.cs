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
    public partial class frmDodajKatergorijuObavijesti : Form
    {
        APIService _obavijestKategorijaService { get; set; } = new APIService("ObavijestKategorija");
        private ObavijestKategorija _obavijestKategorija;

        public frmDodajKatergorijuObavijesti(ObavijestKategorija obavijestKategorija = null)
        {
            InitializeComponent();
            _obavijestKategorija = obavijestKategorija;
        }

        private async void frmDodajKatergorijuObavijesti_Load(object sender, EventArgs e)
        {
            if (_obavijestKategorija != null)
            {
                txtNaziv.Text = _obavijestKategorija.Naziv;
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidanUnos())
                {
                    ObavijestKategorijaInsertRequest obavijestKategorijaInsertRequest = new ObavijestKategorijaInsertRequest
                    {
                        Naziv = txtNaziv.Text
                    };

                    if (_obavijestKategorija == null)
                    {
                        var obavijestKategorija = await _obavijestKategorijaService.Insert<ObavijestKategorija>(obavijestKategorijaInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                    else
                    {
                        var obavijestKategorija = await _obavijestKategorijaService.Update<ObavijestKategorija>(_obavijestKategorija.ObavijestKategorijaId, obavijestKategorijaInsertRequest);
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
            return Validator.ValidirajKontrolu(txtNaziv, err, Kljucevi.ObaveznaVrijednost);
        }
    }
}
