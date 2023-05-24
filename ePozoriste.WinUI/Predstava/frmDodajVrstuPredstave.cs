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
                VrstaPredstaveInsertRequest vrstaPredstaveInsertRequest = new VrstaPredstaveInsertRequest
                {
                    Naziv = txtNaziv.Text
                };

                if (_vrstaPredstave == null)
                {
                    var vrstaPredstave = await _vrstaPredstaveService.Insert<VrstaPredstave>(vrstaPredstaveInsertRequest);
                }
                else
                {
                    var vrstaPredstave = await _vrstaPredstaveService.Update<VrstaPredstave>(_vrstaPredstave.VrstaPredstaveId, vrstaPredstaveInsertRequest);
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
