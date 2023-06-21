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
                    if(_pozoriste.Logo != null)
                        pbLogo.Image = ImageHelper.ConvertStringToImage(_pozoriste.Logo);
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
                if (ValidanUnos())
                {
                    PozoristeInsertRequest pozoristeInsertRequest = new PozoristeInsertRequest
                    {
                        Naziv = txtNaziv.Text,
                        Adresa = txtAdresa.Text,
                        Email = txtEmail.Text,
                        Webstranica = txtWebStranica.Text,
                        BrTelefona = txtBrTelefona.Text,
                        Aktivan = cbAktivan.Checked,
                        GradId = (int)cmbGradovi.SelectedValue,
                        Logo = pbLogo.Image!=null ? ImageHelper.ConvertImageToString(pbLogo.Image) : null
                    };

                    if (_pozoriste == null)
                    {
                        var pozoriste = await _pozoristeService.Insert<Pozoriste>(pozoristeInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                    else
                    {
                        var pozoriste = await _pozoristeService.Update<Pozoriste>(_pozoriste.PozoristeId, pozoristeInsertRequest);
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
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtNaziv, errNaziv, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtAdresa, errAdresa, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbGradovi, errGrad, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtWebStranica, errWebStranica, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtEmail, errEmail, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtBrTelefona, errBrojTelefona, Kljucevi.ObaveznaVrijednost);
        }
    }
}
