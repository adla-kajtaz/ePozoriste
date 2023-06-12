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
    public partial class frmPrikazObavijesti : Form
    {
        APIService _obavijestKategorijaService { get; set; } = new APIService("ObavijestKategorija");
        APIService _obavijestService { get; set; } = new APIService("Obavijest");

        public frmPrikazObavijesti()
        {
            InitializeComponent();
            dgvObavijesti.AutoGenerateColumns = false;
        }

        private async void frmPrikazObavijesti_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new ObavijestSearchObject
                {

                };
                dgvObavijesti.DataSource = await _obavijestService.Get<List<Obavijest>>();
                UcitajKategorije();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajKategorije()
        {
            try
            {
                var kategorija = await _obavijestKategorijaService.Get<List<ObavijestKategorija>>() as IList<ObavijestKategorija>;
                cmbKategorije.DataSource = kategorija;
                cmbKategorije.DisplayMember = "Naziv";
                cmbKategorije.ValueMember = "ObavijestKategorijaId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDetaljiObavijesti frmDetaljiObavijesti = new frmDetaljiObavijesti();
            if (frmDetaljiObavijesti.ShowDialog() == DialogResult.OK)
            {
                dgvObavijesti.DataSource = null;
                frmPrikazObavijesti_Load(sender, e);
            }
        }

        private async void dgvObavijesti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obavijest = dgvObavijesti.SelectedRows[0].DataBoundItem as Obavijest;
            if (e.ColumnIndex == 7)
            {
                await _obavijestService.Delete<Obavijest>(obavijest.ObavijestKategorijaId);
                
                dgvObavijesti.DataSource = null;
                frmPrikazObavijesti_Load(sender, e);
            }
            else if (e.ColumnIndex == 6)
            {
                frmDetaljiObavijesti frmDetaljiObavijesti = new frmDetaljiObavijesti(obavijest);
                if (frmDetaljiObavijesti.ShowDialog() == DialogResult.OK)
                {
                    dgvObavijesti.DataSource = null;
                    frmPrikazObavijesti_Load(sender, e);
                }
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            ObavijestSearchObject obavijestSearchObject = new ObavijestSearchObject
            {
                Tekst = txtPretraga.Text,
                ObavijestKategorijaId = (int)cmbKategorije.SelectedValue
            };
            dgvObavijesti.DataSource = await _obavijestService.Get<List<Obavijest>>(obavijestSearchObject);
        }
    }
}
