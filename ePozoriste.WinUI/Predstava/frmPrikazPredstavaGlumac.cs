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
    public partial class frmPrikazPredstavaGlumac : Form
    {

        APIService _predstavaGlumacService { get; set; } = new APIService("PredstavaGlumac");
        private Predstava _predstava;

        public frmPrikazPredstavaGlumac(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
            txtNazivPredstave.Text = _predstava.Naziv;
            dgvPredstavaGlumci.AutoGenerateColumns = false;
        }

        private async void frmPrikazPredstavaGlumac_Load(object sender, EventArgs e)
        {
            try
            {
                PredstavaGlumacSearchObject predstavaGlumacSearchObject = new PredstavaGlumacSearchObject
                {
                    PredstavaId = _predstava.PredstavaId
                };
                dgvPredstavaGlumci.DataSource = await _predstavaGlumacService.Get<List<PredstavaGlumac>>(predstavaGlumacSearchObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvGlumci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var predstavaGlumac = dgvPredstavaGlumci.SelectedRows[0].DataBoundItem as PredstavaGlumac;
            if (e.ColumnIndex == 2)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovog glumca? Ne možete poništiti ovu radnju!", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;
                if (result == DialogResult.Yes)
                {
                    if (dgvPredstavaGlumci.RowCount == 1)
                    {
                        MessageBox.Show("Predstava mora imati barem jednog glumca.",
                            Resursi.Get(Kljucevi.Upozorenje),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        await _predstavaGlumacService.Delete<PredstavaGlumac>(predstavaGlumac.PredstavaGlumacId);
                        dgvPredstavaGlumci.DataSource = null;
                        frmPrikazPredstavaGlumac_Load(sender, e);
                    }
                }
            }
        }
    }
}
