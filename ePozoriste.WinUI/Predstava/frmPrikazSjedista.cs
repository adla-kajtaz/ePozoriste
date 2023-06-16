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
    public partial class frmPrikazSjedista : Form
    {
        APIService _kartaService { get; set; } = new APIService("Karta");
        APIService _salaService { get; set; } = new APIService("Sala");
        private Sala _sala;
        private Termin _termin;
        private List<Karta> _karte;
        int X = 0;
        int Y = 0;
        char red;
        string redString;
        bool provjera;
        int zauzeto = 0;
        int slobodno = 0;
        public frmPrikazSjedista(Termin termin = null)
        {
            InitializeComponent();
            _termin = termin;
        }

        private async void frmPrikazSjedista_Load(object sender, EventArgs e)
        {
            try
            {
                KartaSearchObject kartaSearchObject = new KartaSearchObject
                {
                    TerminId = _termin.TerminId,
                    Aktivan = null
                };
                _karte = await _kartaService.Get<List<Karta>>(kartaSearchObject);
                _sala = await _salaService.GetById<Sala>(_termin.SalaId);
                lblUkupno.Text = _karte.Count.ToString();


                for(int i = 0; i < _karte.Count; i++)
                {
                    red = (char)(Y + 65);
                    redString = Convert.ToString(red);
                    provjera = string.Equals(redString, _karte[i].BrojReda);
                    if (provjera)
                    {
                        X = 0;
                        Y++;
                    }
                    Button btn = new Button();
                    btn.Text = _karte[i].Sjediste;
                    btn.Name = "btn" + (i+1).ToString();
                    btn.Size = new Size(50, 39);
                    btn.Location = new Point(50 * (X + 1), 40 * (Y+1));
                    if (!_karte[i].Aktivna)
                    {
                        btn.BackColor = Color.Red;
                        zauzeto++;
                    }
                    Controls.Add(btn);
                    X++;
                }
                lblZauzeto.Text = zauzeto.ToString();
                lblSlobodno.Text = (_karte.Count - zauzeto).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
