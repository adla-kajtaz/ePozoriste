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
    public partial class frmDodajPredstavu : Form
    {
        APIService _predstavaService { get; set; } = new APIService("predstava");
        private Predstava _predstava;
        public frmDodajPredstavu(Predstava predstava = null )
        {
            InitializeComponent();
            _predstava = predstava; 
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
                 // pbSlikaPlakata
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
                PredstavaInsertRequest predstavaInsertRequest = new PredstavaInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    Sadrzaj = txtSadrzaj.Text,
                    VrijemeTrajanje = Int32.Parse(txtVrijemeTrajanja.Text),
                    Rezija = txtRezija.Text,
                    Scenografija = txtScenografija.Text,
                    Kostimografija = txtKostimografija.Text
                 // Slika 
                };

                if (_predstava == null)
                {
                    var predstava = await _predstavaService.Insert<Pozoriste>(predstavaInsertRequest);
                }
                else
                {
                    var predstava = await _predstavaService.Update<Pozoriste>(_predstava.PredstavaId, predstavaInsertRequest);
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
