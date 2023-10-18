using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
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
    public partial class frmPrikazTermina : Form
    {
        APIService _terminService { get; set; } = new APIService("Termin");
        APIService _predstavaService { get; set; } = new APIService("Predstava");
        private Sala _sala;
        private bool datumPromijenjen = false;
        private bool cbPremijeraPromijenjen = false;
        private bool cbPredpremijeraPromijenjen = false;

        public frmPrikazTermina(Sala sala = null)
        {
            InitializeComponent();
            dgvTermini.AutoGenerateColumns = false;
            _sala = sala;
            dgvTermini.Columns["DatumIzvodjenja"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private async void frmPrikazTermina_Load(object sender, EventArgs e)
        {
            LoadData();
            UcitajPredstave();
           
        }

        private async Task LoadData()
        {
            try{
                var searchRequest = new TerminSearchObject
                {
                    SalaId = _sala.SalaId
                };
                dgvTermini.DataSource = await _terminService.Get<List<Termin>>(searchRequest);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajPredstave()
        {
            try
            {
                var predstave = await _predstavaService.Get<List<Predstava>>() as IList<Predstava>;

                var allOption = new Predstava
                {
                    PredstavaId = -1, 
                    Naziv = "Sve"
                };

                predstave.Insert(0, allOption);

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
            frmDodavanjeTermina frmDodavanjeTermina = new frmDodavanjeTermina(_sala);
            if (frmDodavanjeTermina.ShowDialog() == DialogResult.OK)
            {
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            TerminSearchObject terminSearchObject = new TerminSearchObject();
            terminSearchObject.SalaId = _sala.SalaId;

            if(cbPredpremijeraPromijenjen)
                terminSearchObject.Predpremijera = cbPredpremijera.Checked;

            if (cbPremijeraPromijenjen)
                terminSearchObject.Premijera = cbPremijera.Checked;

            if (datumPromijenjen)
                terminSearchObject.DatumOdrzavanja = dtpDatumIzvodjenja.Value;

            if ((int)cmbPredstave.SelectedValue != -1)
                terminSearchObject.PredstavaId = (int)cmbPredstave.SelectedValue;
              
            dgvTermini.DataSource = await _terminService.Get<List<Termin>>(terminSearchObject);
        }

        private async void dgvTermini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var termini = dgvTermini.SelectedRows[0].DataBoundItem as Termin;
            if (e.ColumnIndex == 9)
            {
               var termin =  await _terminService.Delete<Termin>(termini.TerminId);
                if(termin == null)
                MessageBox.Show(Resursi.Get(Kljucevi.NeMozeteObrisati),
                                      Resursi.Get(Kljucevi.Informacija),
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);

            }
            else if (e.ColumnIndex == 8)
            {
                frmDodavanjeTermina frmDodavanjeTermina = new frmDodavanjeTermina(_sala,termini);
                if (frmDodavanjeTermina.ShowDialog() == DialogResult.OK)
                {
                    dgvTermini.DataSource = null;
                    frmPrikazTermina_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 7)
            {
                frmPrikazKarata frmPrikazKarata = new frmPrikazKarata(termini);
                if (frmPrikazKarata.ShowDialog() == DialogResult.OK)
                {
                    dgvTermini.DataSource = null;
                    frmPrikazTermina_Load(sender, e);
                }
            }
        }

        private void dtpDatumIzvodjenja_ValueChanged(object sender, EventArgs e)
        {
            datumPromijenjen = true;
        }

        private void cbPremijera_CheckedChanged(object sender, EventArgs e)
        {
            cbPremijeraPromijenjen = true;
        }

        private void cbPredpremijera_CheckedChanged(object sender, EventArgs e)
        {
            cbPredpremijeraPromijenjen = true;
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            dtpDatumIzvodjenja.ResetText();
            cbPremijera.Checked = false;
            cbPredpremijera.Checked = false;

            datumPromijenjen = false;
            cbPremijeraPromijenjen = false;
            cbPredpremijeraPromijenjen = false;

            await LoadData();
        }
    }
}
