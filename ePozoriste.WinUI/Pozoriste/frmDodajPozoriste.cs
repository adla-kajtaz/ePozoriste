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
    public partial class frmDodajPozoriste : Form
    {
        APIService _gradService { get; set; } = new APIService("Grad");
        APIService _pozoristeService { get; set; } = new APIService("Pozoriste");
        private Pozoriste _pozoriste;
        public frmDodajPozoriste(Pozoriste pozoriste= null)
        {
            InitializeComponent();
            _pozoriste = pozoriste;
            UcitajGradove();
        }

        private async void frmDodajPozoriste_Load(object sender, EventArgs e)
        {
            try
            {
                if (_pozoriste != null)
                {
                    txtNaziv.Text = _pozoriste.Naziv;
                    txtAdresa.Text = _pozoriste.Adresa;
                    txtBrTelefona.Text = _pozoriste.BrTelefona;
                    txtEmail.Text = _pozoriste.Email;
                    txtWebStranica.Text = _pozoriste.Webstranica;
                    cbAktivan.Checked = _pozoriste.Aktivan;
                    cmbGradovi.SelectedValue = _pozoriste.GradId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajGradove()
        {
            try
            {
                var gradovi = await _gradService.Get<List<Grad>>() as IList<Grad>;
                cmbGradovi.DataSource = gradovi;
                cmbGradovi.DisplayMember = "Naziv";
                cmbGradovi.ValueMember = "GradId";
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
                PozoristeInsertRequest pozoristeInsertRequest = new PozoristeInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    Adresa = txtAdresa.Text, 
                    Email = txtEmail.Text,
                    Webstranica = txtWebStranica.Text,
                    BrTelefona = txtBrTelefona.Text,
                    Aktivan = cbAktivan.Checked,
                    GradId = (int)cmbGradovi.SelectedValue
                };

                if (_pozoriste == null)
                {
                    var pozoriste = await _pozoristeService.Insert<Pozoriste>(pozoristeInsertRequest);
                }
                else
                {
                    var pozoriste = await _pozoristeService.Update<Pozoriste>(_pozoriste.PozoristeId, pozoristeInsertRequest);
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
