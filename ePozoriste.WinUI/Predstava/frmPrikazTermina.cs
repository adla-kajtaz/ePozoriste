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
    public partial class frmPrikazTermina : Form
    {
        APIService _terminService { get; set; } = new APIService("Termin");
        APIService _predstavaService { get; set; } = new APIService("Predstava");
        APIService _salaService { get; set; } = new APIService("Sala");

        public frmPrikazTermina()
        {
            InitializeComponent();
            dgvTermini.AutoGenerateColumns = false;
        }

        private async void frmPrikazTermina_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new TerminSearchObject
                {

                };
                dgvTermini.DataSource = await _terminService.Get<List<Termin>>();
                UcitajPredstave();
                UcitajSale();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajSale()
        {
            try
            {
                var sale = await _salaService.Get<List<Sala>>() as IList<Sala>;
                cmbSale.DataSource = sale;
                cmbSale.DisplayMember = "Naziv";
                cmbSale.ValueMember = "SalaId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajPredstave()
        {
            try
            {
                var predstave = await _predstavaService.Get<List<Predstava>>() as IList<Predstava>;
                cmbPredstave.DataSource = predstave;
                cmbPredstave.DisplayMember = "Naziv";
                cmbPredstave.ValueMember = "PredstavaId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodavanjeTermina frmDodavanjeTermina = new frmDodavanjeTermina();
            if (frmDodavanjeTermina.ShowDialog() == DialogResult.OK)
            {
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            TerminSearchObject terminSearchObject = new TerminSearchObject
            {
                Predpremijera = cbPredpremijera.Checked,
                Premijera = cbPremijera.Checked,
                SalaId = (int)cmbSale.SelectedValue,
                PredstavaId = (int)cmbPredstave.SelectedValue
            };
            dgvTermini.DataSource = await _terminService.Get<List<Termin>>(terminSearchObject);
        }

        private async void dgvTermini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var termini = dgvTermini.SelectedRows[0].DataBoundItem as Termin;
            if (e.ColumnIndex == 9)
            {
                await _terminService.Delete<Termin>(termini.TerminId);
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);

            }
            else if (e.ColumnIndex == 8)
            {
                frmDodavanjeTermina frmDodavanjeTermina = new frmDodavanjeTermina(termini);
                if (frmDodavanjeTermina.ShowDialog() == DialogResult.OK)
                {
                    dgvTermini.DataSource = null;
                    frmPrikazTermina_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 7)
            {
               // karte
            }
        }
    }
}
