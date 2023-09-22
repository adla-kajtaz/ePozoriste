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
    public partial class frmLogin : Form
    {
        AuthService authService { get; set; } = new AuthService();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            APIService.KorisnickoIme = txtKorisnickoIme.Text;
            APIService.Lozinka = txtLozinka.Text;
      
             try
             {
                if (ValidanUnos())
                {
                    var loginRequest = new LoginRequest
                    {
                        KorisnickoIme = txtKorisnickoIme.Text.ToString(),
                        Lozinka = txtLozinka.Text.ToString()
                    };

                    var korisnik = await authService.LoginAdmin(loginRequest);
                    if (korisnik != null)
                    {

                        APIService.LogiraniKorisnikId = korisnik.KorisnikId;
                        frmMeni frmMeni = new frmMeni();
                        frmMeni.Show();
                        this.Hide();
                    }
                }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtKorisnickoIme, errKorisnickoIme, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajLozinku(txtLozinka, errLozinka, Kljucevi.DuzinaLozinke);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
