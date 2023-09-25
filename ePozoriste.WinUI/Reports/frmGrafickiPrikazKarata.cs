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
    public partial class frmGrafickiPrikazKarata : Form
    {
        APIService _kartaService { get; set; } = new APIService("Karta");
        private Termin _termin;
        public frmGrafickiPrikazKarata(Termin termin = null)
        {
            InitializeComponent();
            _termin = termin;
        }

        private async void frmGrafickiPrikazKarata_Load(object sender, EventArgs e)
        {
            KartaSearchObject kartaSearchObject = new KartaSearchObject
            {
                TerminId = _termin.TerminId,
            };
           var karte = await _kartaService.Get<List<Karta>>(kartaSearchObject);

           var rpc = new ReportParameterCollection();
           rpc.Add(new ReportParameter("pNazivPredstave", _termin.Predstava.Naziv));

            var tabela = new dsEPozoriste.KarteDataTable();
            int brProdanih =0, brNeProdanih = 0;
            foreach (Karta karta in karte)
            {
                if (karta.Aktivna)
                    brNeProdanih += 1;
                else
                    brProdanih += 1;
            }

            var red = tabela.NewKarteRow();
            red.Status = "NIJE PRODANA";
            red.UkupanBroj = brNeProdanih;
            tabela.AddKarteRow(red);

            var red2 = tabela.NewKarteRow();
            red2.Status = "PRODANA";
            red2.UkupanBroj = brProdanih;
            tabela.AddKarteRow(red2);

            var rds = new ReportDataSource();
             rds.Name = "DataSet1";
            rds.Value = tabela; 

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
