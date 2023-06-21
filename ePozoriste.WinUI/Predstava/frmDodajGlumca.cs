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
    public partial class frmDodajGlumca : Form
    {
        APIService _glumacService { get; set; } = new APIService("Glumac");
        private Glumac _glumac;
        public frmDodajGlumca(Glumac glumac = null)
        {
            InitializeComponent();
            _glumac = glumac;   
        }

        private async void frmDodajGlumca_Load(object sender, EventArgs e)
        {
            if (_glumac != null)
            {
                txtIme.Text = _glumac.Ime;
                txtPrezime.Text = _glumac.Prezime;
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidanUnos())
                {
                    GlumacInsertRequest glumacInsertRequest = new GlumacInsertRequest
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        ImePrezime = $"{txtIme.Text} {txtPrezime.Text}"
                    };

                    if (_glumac == null)
                    {
                        var glumac = await _glumacService.Insert<Glumac>(glumacInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                    else
                    {
                        var glumac = await _glumacService.Update<Glumac>(_glumac.GlumacId, glumacInsertRequest);
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
            return Validator.ValidirajKontrolu(txtIme, errIme, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, errPrezime, Kljucevi.ObaveznaVrijednost);
        }
    }
}
