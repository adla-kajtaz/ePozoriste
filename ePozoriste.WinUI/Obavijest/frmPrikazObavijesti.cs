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
                var kategorije = await _obavijestKategorijaService.Get<List<ObavijestKategorija>>() as IList<ObavijestKategorija>;

                var allOption = new ObavijestKategorija
                {
                    ObavijestKategorijaId = -1,
                    Naziv = "Sve"
                };

                kategorije.Insert(0, allOption);

                cmbKategorije.DataSource = kategorije;
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
            frmDodajObavijest frmDodajObavijest = new frmDodajObavijest();
            if (frmDodajObavijest.ShowDialog() == DialogResult.OK)
            {
                dgvObavijesti.DataSource = null;
                frmPrikazObavijesti_Load(sender, e);
            }
        }

        private async void dgvObavijesti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obavijest = dgvObavijesti.SelectedRows[0].DataBoundItem as Obavijest;
            if (e.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovu obavijest? Ne možete poništiti ovu radnju!", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;
                if (result == DialogResult.Yes)
                {
                    await _obavijestService.Delete<Obavijest>(obavijest.ObavijestId);

                    dgvObavijesti.DataSource = null;
                    frmPrikazObavijesti_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 5)
            {
                frmDodajObavijest frmDodajObavijest = new frmDodajObavijest(obavijest);
                if (frmDodajObavijest.ShowDialog() == DialogResult.OK)
                {
                    dgvObavijesti.DataSource = null;
                    frmPrikazObavijesti_Load(sender, e);
                }
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            ObavijestSearchObject obavijestSearchObject = new ObavijestSearchObject();
            obavijestSearchObject.Tekst = txtPretraga.Text;

            if ((int)cmbKategorije.SelectedValue != -1)
                obavijestSearchObject.ObavijestKategorijaId = (int)cmbKategorije.SelectedValue;

            dgvObavijesti.DataSource = await _obavijestService.Get<List<Obavijest>>(obavijestSearchObject);
        }
    }
}
