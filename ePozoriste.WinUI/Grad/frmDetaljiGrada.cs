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
    public partial class frmDetaljiGrada : Form
    {
        APIService _gradService { get; set; } = new APIService("Grad");
        APIService _drzavaService { get; set; } = new APIService("Drzava");
        private Grad _grad;

        public frmDetaljiGrada(Grad grad = null)
        {
            InitializeComponent();
            _grad = grad;
            UcitajDrzave();
        }

        private async void frmDetaljiGrada_Load(object sender, EventArgs e)
        {
            try
            {
                if (_grad != null)
                {
                    txtNaziv.Text = _grad.Naziv;
                    txtPostanskiBr.Text = _grad.PostanskiBr;
                    cmbDrzave.SelectedValue = _grad.DrzavaId;
                }
                //UcitajDrzave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajDrzave()
        {
            try
            {
                var drzava = await _drzavaService.Get<List<Drzava>>() as IList<Drzava>;
                cmbDrzave.DataSource = drzava;
                cmbDrzave.DisplayMember = "Naziv";
                cmbDrzave.ValueMember = "DrzavaId";
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
                GradInsertRequest gradInsertRequest = new GradInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    PostanskiBr=txtPostanskiBr.Text,
                    DrzavaId=(int)cmbDrzave.SelectedValue
                };

                if (_grad == null)
                {
                    var grad = await _gradService.Insert<Grad>(gradInsertRequest);
                }
                else
                {
                    var grad = await _gradService.Update<Grad>(_grad.GradId, gradInsertRequest);
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
