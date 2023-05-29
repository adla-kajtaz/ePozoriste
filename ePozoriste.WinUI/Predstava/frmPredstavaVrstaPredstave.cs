using ePozoriste.Model;
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
    public partial class frmPredstavaVrstaPredstave : Form
    {
        APIService _vrstaPredstaveService { get; set; } = new APIService("VrstaPredstave");
        private Predstava _predstava;
        public frmPredstavaVrstaPredstave(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
            txtNazivPredstave.Text = _predstava.Naziv;
            UcitajVrstePredstava();
        }

        private async void UcitajVrstePredstava()
        {
            var vrste = await _vrstaPredstaveService.Get<List<VrstaPredstave>>() as IList<VrstaPredstave>;
            cblVrstePredstave.DataSource = vrste;
            cblVrstePredstave.DisplayMember = "Naziv";
            cblVrstePredstave.ValueMember = "VrstaPredstaveId";
        }
    }
}
