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
                ObavijestKategorijaInsertRequest obavijestKategorijaInsertRequest = new ObavijestKategorijaInsertRequest
                {
                    Naziv = txtNaziv.Text
                };

                if (_obavijestKategorija == null)
                {
                    var obavijestKategorija = await _obavijestKategorijaService.Insert<ObavijestKategorija>(obavijestKategorijaInsertRequest);
                }
                else
                {
                    var obavijestKategorija = await _obavijestKategorijaService.Update<ObavijestKategorija>(_obavijestKategorija.ObavijestKategorijaId, obavijestKategorijaInsertRequest);
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
