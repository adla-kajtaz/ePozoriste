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
    public partial class frmGlumacPredstava : Form
    {
        APIService _glumciService { get; set; } = new APIService("Glumac");
        APIService _predstavaGlumacService { get; set; } = new APIService("PredstavaGlumac");
        private Predstava _predstava;
        public frmGlumacPredstava(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
            txtNazivPredstave.Text = _predstava.Naziv;
            UcitajGlumce();
        }

        private async void UcitajGlumce()
        {
            try
            {
                var glumac = await _glumciService.Get<List<Glumac>>() as IList<Glumac>;
                cmbGlumac.DataSource = glumac;
                cmbGlumac.DisplayMember = "Ime";
                cmbGlumac.ValueMember = "GlumacId";
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
                PredstavaGlumacInsertRequest predstavaGlumacInsertRequest = new PredstavaGlumacInsertRequest
                {
                    PredstavaId = _predstava.PredstavaId,
                    NazivUloge = txtNazivUloge.Text,
                    GlumacId = (int)cmbGlumac.SelectedValue
                };
                
                var predstavaGlumac = await _predstavaGlumacService.Insert<PredstavaGlumac>(predstavaGlumacInsertRequest);
                
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
