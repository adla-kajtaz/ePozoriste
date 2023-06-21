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
    public partial class frmDodajVrstuPredstave : Form
    {
        APIService _vrstaPredstaveService { get; set; } = new APIService("VrstaPredstave");
        private VrstaPredstave _vrstaPredstave;

        public frmDodajVrstuPredstave(VrstaPredstave vrstaPredstave = null)
        {
            InitializeComponent();
            _vrstaPredstave = vrstaPredstave;   
        }

        private async void frmDodajVrstuPredstave_Load(object sender, EventArgs e)
        {
            if (_vrstaPredstave != null)
            {
                txtNaziv.Text = _vrstaPredstave.Naziv;
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidanUnos())
                {
                    VrstaPredstaveInsertRequest vrstaPredstaveInsertRequest = new VrstaPredstaveInsertRequest
                    {
                        Naziv = txtNaziv.Text
                    };

                    if (_vrstaPredstave == null)
                    {
                        var vrstaPredstave = await _vrstaPredstaveService.Insert<VrstaPredstave>(vrstaPredstaveInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                    else
                    {
                        var vrstaPredstave = await _vrstaPredstaveService.Update<VrstaPredstave>(_vrstaPredstave.VrstaPredstaveId, vrstaPredstaveInsertRequest);
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
