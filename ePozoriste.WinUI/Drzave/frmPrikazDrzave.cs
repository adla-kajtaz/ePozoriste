using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
using ePozoriste.WinUI.Drzave;

namespace ePozoriste.WinUI
{
    public partial class frmPrikazDrzave : Form
    {
        APIService _drzavaService { get; set; } = new APIService("Drzava");
        public frmPrikazDrzave()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetaljiDrzave frmDetalji = new frmDetaljiDrzave();
            if (frmDetalji.ShowDialog() == DialogResult.OK)
            {
                dgvDrzave.DataSource = null;
                frmPrikazDrzava_Load(sender, e);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            BaseSearchObject drzavaSearchRequest = new BaseSearchObject
            {
                Tekst = txtPretraga.Text
            };
            dgvDrzave.DataSource = await _drzavaService.Get<List<Drzava>>(drzavaSearchRequest);
        }

        private async void frmPrikazDrzava_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new BaseSearchObject
                {

                };
                dgvDrzave.DataSource = await _drzavaService.Get<List<Drzava>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvDrzava_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var drzava = dgvDrzave.SelectedRows[0].DataBoundItem as Drzava;
            if (e.ColumnIndex == 4)
            {
                //var obrisanaDrazva=
                await _drzavaService.Delete<Drzava>(drzava.DrzavaId);
                //if (obrisanaDrazva != null){
                dgvDrzave.DataSource = null;
                frmPrikazDrzava_Load(sender, e);
                /*}
                else
                {
                    MessageBox.Show("Greska");
                }*/
            }
            else if (e.ColumnIndex == 3)
            {
                frmDetaljiDrzave frmDetalji = new frmDetaljiDrzave(drzava);
                if (frmDetalji.ShowDialog() == DialogResult.OK)
                {
                    dgvDrzave.DataSource = null;
                    frmPrikazDrzava_Load(sender, e);
                }
            }
        }
    }
}