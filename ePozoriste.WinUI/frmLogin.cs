using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
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
        private readonly APIService _korisnikService  = new APIService("Korisnik");
        private readonly APIService _korisnikUlogeService   = new APIService("KorisnikUloge");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            APIService.KorisnickoIme = txtKorisnickoIme.Text;
            APIService.Lozinka = txtLozinka.Text;
            bool admin = false;

            try
            {
                var korisnici = await _korisnikService.Get<List<Korisnik>>();

                var korisnik = korisnici.First(x => x.KorisnickoIme == txtKorisnickoIme.Text);

                var korisnikUlogeSearchObject = new KorisnikUlogeSearchObject
                {
                    KorisnikId = korisnik.KorisnikId
                };
                var uloge = await _korisnikUlogeService.Get<List<KorisnikUloge>>(korisnikUlogeSearchObject);

                foreach (var uloga in uloge)
                {
                    if (uloga.Uloga.Naziv == "Admin")
                    {
                        admin = true;
                    }
                }
                if (admin)
                {
                    frmMeni frmMeni = new frmMeni();
                    frmMeni.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Nemate permisije");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pogrešan email ili lozinka");
            }
        }
    }
}
