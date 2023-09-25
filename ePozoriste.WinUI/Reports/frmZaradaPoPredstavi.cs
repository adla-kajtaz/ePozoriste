using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ePozoriste.WinUI.Reports
{
    public partial class frmZaradaPoPredstavi : Form
    {
        APIService _terminService { get; set; } = new APIService("Termin");
        APIService _kartaService { get; set; } = new APIService("Karta");
        private Predstava _predstava;
        public frmZaradaPoPredstavi(Predstava predstava)
        {
            InitializeComponent();
            _predstava = predstava;
        }

        private async void frmZaradaPoPredstavi_Load(object sender, EventArgs e)
        {

            TerminSearchObject terminSearchObject = new TerminSearchObject
            {
                PredstavaId =_predstava.PredstavaId,
            };
            var termini = await _terminService.Get<List<Termin>>(terminSearchObject);
            int brKarata = 0;
            int cijena = 0;
            int zarada = 0;
            foreach (Termin termin in termini)
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
     
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pNazivPredstave",_predstava.Naziv));
            rpc.Add(new ReportParameter("pProdaneKarte", brKarata.ToString()));
            rpc.Add(new ReportParameter("pCijena", cijena.ToString()));
            rpc.Add(new ReportParameter("pZarada", zarada.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
