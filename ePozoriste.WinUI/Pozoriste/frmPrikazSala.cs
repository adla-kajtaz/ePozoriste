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
    public partial class frmPrikazSala : Form
    {
        APIService _salaService { get; set; } = new APIService("Sala");
        APIService _pozoristeService { get; set; } = new APIService("Pozoriste");

        public frmPrikazSala()
        {
            InitializeComponent();
            dgvSale.AutoGenerateColumns = false;
        }

        private async void frmPrikazSala_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new SalaSearchObject
                {

                };
                dgvSale.DataSource = await _salaService.Get<List<Sala>>();
                UcitajPozorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UcitajPozorista()
        {
            try
            {
                var pozorista = await _pozoristeService.Get<List<Pozoriste>>() as IList<Pozoriste>;
                cmbPozorista.DataSource = pozorista;
                cmbPozorista.DisplayMember = "Naziv";
                cmbPozorista.ValueMember = "PozoristeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajSalu frmDodajSalu = new frmDodajSalu();
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
                PozoristeId = (int)cmbPozorista.SelectedValue
            };
            dgvSale.DataSource = await _salaService.Get<List<Sala>>(salaSearchObject);
        }

        private async void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sala = dgvSale.SelectedRows[0].DataBoundItem as Sala;
            if (e.ColumnIndex == 6)
            {
                //var obrisanoPozoriste=
                await _salaService.Delete<Sala>(sala.SalaId);
                //if (obrisanoPozoriste != null){
                dgvSale.DataSource = null;
                frmPrikazSala_Load(sender, e);
                /*}
                else
                {
                    MessageBox.Show("Greska");
                }*/
            }
            else if (e.ColumnIndex == 5)
            {
                frmDodajSalu frmDodajSalu = new frmDodajSalu(sala);
                if (frmDodajSalu.ShowDialog() == DialogResult.OK)
                {
                    dgvSale.DataSource = null;
                    frmPrikazSala_Load(sender, e);
                }
            }
        }
    }
}
