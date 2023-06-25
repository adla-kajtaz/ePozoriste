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
    public partial class frmMeni : Form
    {
        public frmMeni()
        {
            InitializeComponent();
        }

        private void btnDrzava_Click(object sender, EventArgs e)
        {
            frmPrikazDrzave frmPrikazDrzave = new frmPrikazDrzave();
            frmPrikazDrzave.Show();
        }

        private void btnGlumci_Click(object sender, EventArgs e)
        {
            frmPrikazGlumaca frmPrikazGlumaca = new frmPrikazGlumaca();
            frmPrikazGlumaca.Show();
        }

        private void btnGradovi_Click(object sender, EventArgs e)
        {
            frmPrikazGradova frmPrikazGradova = new frmPrikazGradova();
            frmPrikazGradova.Show();
        }

        private void btnPredstave_Click(object sender, EventArgs e)
        {
            frmPrikazPredstava frmPrikazPredstava = new frmPrikazPredstava();
            frmPrikazPredstava.Show();
        }

        private void btnPozorista_Click(object sender, EventArgs e)
        {
            frmPrikazPozorista frmPrikazPozorista = new frmPrikazPozorista();
            frmPrikazPozorista.Show();
        }

        private void btnTermini_Click(object sender, EventArgs e)
        {
            frmPrikazTermina frmPrikazTermina = new frmPrikazTermina();
            frmPrikazTermina.Show();
        }

        private void btnVrstePredstave_Click(object sender, EventArgs e)
        {
            frmPrikazVrstaPredstave frmPrikazVrstaPredstave = new frmPrikazVrstaPredstave();
            frmPrikazVrstaPredstave.Show();
        }

        private void btnKategorijeObavijesti_Click(object sender, EventArgs e)
        {
            frmPrikazKategorijeObavijesti frmPrikazKategorijeObavijesti = new frmPrikazKategorijeObavijesti();
            frmPrikazKategorijeObavijesti.Show();
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            frmPrikazObavijesti frmPrikazObavijesti = new frmPrikazObavijesti();
            frmPrikazObavijesti.Show();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfil frmProfil = new frmProfil();
            frmProfil.Show();
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
    }
}
