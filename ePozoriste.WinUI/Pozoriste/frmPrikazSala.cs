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
    public partial class frmPrikazSala : Form
    {
        APIService _salaService { get; set; } = new APIService("Sala");
        APIService _pozoristeService { get; set; } = new APIService("Pozoriste");
        private int _pozoristeId;

        public frmPrikazSala(int pozoristeId)
        {
            InitializeComponent();
            dgvSale.AutoGenerateColumns = false;
            _pozoristeId = pozoristeId;
        }

        private async void frmPrikazSala_Load(object sender, EventArgs e)
        {
            try
            {
                SalaSearchObject salaSearchObject = new SalaSearchObject
                {
                    Tekst = null,
                    PozoristeId = _pozoristeId
                };
                dgvSale.DataSource = await _salaService.Get<List<Sala>>(salaSearchObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajSalu frmDodajSalu = new frmDodajSalu(_pozoristeId);
            if (frmDodajSalu.ShowDialog() == DialogResult.OK)
            {
                dgvSale.DataSource = null;
                frmPrikazSala_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            SalaSearchObject salaSearchObject = new SalaSearchObject
            {
                Tekst = txtPretraga.Text,
                PozoristeId = _pozoristeId
            };
            dgvSale.DataSource = await _salaService.Get<List<Sala>>(salaSearchObject);
        }

        private async void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sala = dgvSale.SelectedRows[0].DataBoundItem as Sala;
            if (e.ColumnIndex == 5)
            {
                var _sala = await _salaService.Delete<Sala>(sala.SalaId);
                if (_sala == null)
                    MessageBox.Show(Resursi.Get(Kljucevi.NeMozeteObrisati),
                                          Resursi.Get(Kljucevi.Informacija),
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                dgvSale.DataSource = null;
                frmPrikazSala_Load(sender, e);
            }
            else if (e.ColumnIndex == 4)
            {
                frmDodajSalu frmDodajSalu = new frmDodajSalu(_pozoristeId, sala);
                if (frmDodajSalu.ShowDialog() == DialogResult.OK)
                {
                    dgvSale.DataSource = null;
                    frmPrikazSala_Load(sender, e);
                }
            }
            else if (e.ColumnIndex == 6)
            {
                frmPrikazTermina frmPrikazTermina = new frmPrikazTermina(sala);
                if (frmPrikazTermina.ShowDialog() == DialogResult.OK)
                {
                    dgvSale.DataSource = null;
                    frmPrikazSala_Load(sender, e);
                }
            }
        }
    }
}
