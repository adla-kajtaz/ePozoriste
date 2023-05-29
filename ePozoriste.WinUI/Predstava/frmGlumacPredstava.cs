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
    public partial class frmGlumacPredstava : Form
    {
        APIService _glumciService { get; set; } = new APIService("Glumac");
        private Predstava _predstava;
        public frmGlumacPredstava(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
            txtNazivPredstave.Text = _predstava.Naziv;
            UcitajGlumce();
        }

        private async void UcitajGlumce()
        {
            var vrste = await _glumciService.Get<List<Glumac>>() as IList<Glumac>;
            cblGlumci.DataSource = vrste;
            cblGlumci.DisplayMember = "Ime";
            cblGlumci.ValueMember = "GlumacId";
        }
    }
}
