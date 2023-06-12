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
    public partial class frmPrikazKarata : Form
    {
        APIService _kartaService { get; set; } = new APIService("Karta");
        private Termin _termin;
        public frmPrikazKarata(Termin termin = null)
        {
            InitializeComponent();
            dgvKarte.AutoGenerateColumns = false;
            _termin = termin;
        }

        private async void frmPrikazKarata_Load(object sender, EventArgs e)
        {
            try
            {
                KartaSearchObject kartaSearchObject = new KartaSearchObject
                {
                    TerminId = _termin.TerminId,
                    Aktivan = null
                };
                dgvKarte.DataSource = await _kartaService.Get<List<Karta>>(kartaSearchObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KartaSearchObject kartaSearchObject = new KartaSearchObject
            {
                TerminId = _termin.TerminId,
                Aktivan = cbAktivna.Checked
            };
            dgvKarte.DataSource = await _kartaService.Get<List<Karta>>(kartaSearchObject);
        }

        private void btnSjedista_Click(object sender, EventArgs e)
        {

        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            KartaSearchObject kartaSearchObject = new KartaSearchObject
            {
                TerminId = _termin.TerminId,
                Aktivan = null
            };
            var list = await _kartaService.Get<List<Karta>>(kartaSearchObject);
            for (int i = 0; i < list.Count; i++)
            {
                await _kartaService.Delete<Karta>(list[i].KartaId);
            }
            dgvKarte.DataSource = null;
            frmPrikazKarata_Load(sender, e);
            MessageBox.Show("Uspjesno obrisano");
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
