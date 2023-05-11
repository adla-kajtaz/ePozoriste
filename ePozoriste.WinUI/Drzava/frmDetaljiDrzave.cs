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
    public partial class frmDetaljiDrzave : Form
    {
        APIService _drzavaService { get; set; } = new APIService("Drzava");
        private Drzava _drzava;
        public frmDetaljiDrzave(Drzava drzava = null)
        {
            InitializeComponent();
            _drzava = drzava;
        }

        private async void frmDetaljiDrzave_Load(object sender, EventArgs e)
        {
            if (_drzava != null)
            {
                txtNaziv.Text = _drzava.Naziv;
                txtSkracenica.Text = _drzava.Skracenica;
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                DrzavaInsertRequest drzavaInsertRequest = new DrzavaInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    Skracenica = txtSkracenica.Text
                };

                if (_drzava == null)
                {
                    var drzava = await _drzavaService.Insert<Drzava>(drzavaInsertRequest);
                }
                else
                {
                    var drzava = await _drzavaService.Update<Drzava>(_drzava.DrzavaId, drzavaInsertRequest);
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
