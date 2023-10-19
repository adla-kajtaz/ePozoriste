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
    public partial class frmProfil : Form
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private Korisnik _korisnik = null;

        public frmProfil()
        {
            InitializeComponent();
        }

        private async void frmProfil_Load(object sender, EventArgs e)
        {
            try
            {
                var korisnici = await _korisnikService.Get<List<Korisnik>>();

                var korisnik = korisnici.First(x => x.KorisnickoIme == APIService.KorisnickoIme);

                if (korisnik != null)
                {
                    _korisnik = korisnik;
                    txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                    txtIme.Text = korisnik.Ime;
                    txtPrezime.Text = korisnik.Prezime;
                    txtBrTelefona.Text = korisnik.BrTelefona;
                    txtEmail.Text = korisnik.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            APIService.KorisnickoIme = "";
            APIService.Lozinka = "";
            APIService.LogiraniKorisnikId = 0;
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidanUnos())
                {
                    KorisnikUpdateRequest korisnikUpdateRequest = new KorisnikUpdateRequest
                    {
                        Ime = txtIme.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Prezime = txtPrezime.Text,
                        BrTelefona = txtBrTelefona.Text,
                        Email = txtEmail.Text
                    };

                    var update = await _korisnikService.Update<Korisnik>(_korisnik.KorisnikId, korisnikUpdateRequest);
                    if (update != null)
                    {
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoModifikovani),
                                      Resursi.Get(Kljucevi.Informacija),
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        APIService.KorisnickoIme = update.KorisnickoIme;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
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
            return Validator.ValidirajKontrolu(txtIme, errIme, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtKorisnickoIme, errKorisnickoIme, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, errPrezime, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtBrTelefona, errBrTelefona, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajBrTelefona(txtBrTelefona, errBrTelefona, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtEmail, errEmail, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajEmail(txtEmail, errEmail, Kljucevi.ObaveznaVrijednost);
        }
    }
}
