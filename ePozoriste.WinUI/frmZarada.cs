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
    public partial class frmZarada : Form
    {
        APIService _predstavaService { get; set; } = new APIService("Predstava");
        APIService _terminService { get; set; } = new APIService("Termin");
        APIService _kartaService { get; set; } = new APIService("Karta");


        public frmZarada()
        {
            InitializeComponent();
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

        private async void frmZarada_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPredstave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            TerminSearchObject terminSearchObject = new TerminSearchObject
            {
                PredstavaId = (int)cmbPredstave.SelectedValue,
            };
            var termini = await _terminService.Get<List<Termin>>(terminSearchObject);
            int brKarata = 0;
            int cijena = 0;
            int zarada = 0;
            foreach(Termin termin in termini)
            {
                KartaSearchObject kartaSearchObject = new KartaSearchObject
                {
                    TerminId = termin.TerminId,
                };
                var karte = await _kartaService.Get<List<Karta>>(kartaSearchObject);

                brKarata += karte.Where(x => x.Aktivna == false).Count();
                cijena = termin.CijenaKarte;
                zarada += (brKarata * cijena);
            }
            txtBrKarata.Text = brKarata.ToString();
            txtCijena.Text = cijena.ToString();
            txtZarada.Text = zarada.ToString();
        }
    }
}
