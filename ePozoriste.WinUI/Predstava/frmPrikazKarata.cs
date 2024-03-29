﻿using ePozoriste.Model;
using ePozoriste.Model.SearchObjects;
using ePozoriste.WinUI.Helper;
using ePozoriste.WinUI.Reports;
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
    public partial class frmPrikazKarata : Form
    {
        APIService _kartaService { get; set; } = new APIService("Karta");
        private Termin _termin;
        public frmPrikazKarata(Termin termin = null)
        {
            InitializeComponent();
            dgvKarte.AutoGenerateColumns = false;
            _termin = termin;
        }

        private async void frmPrikazKarata_Load(object sender, EventArgs e)
        {
            try
            {
                KartaSearchObject kartaSearchObject = new KartaSearchObject
                {
                    TerminId = _termin.TerminId,
                    Aktivan = null
                };
                dgvKarte.DataSource = await _kartaService.Get<List<Karta>>(kartaSearchObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KartaSearchObject kartaSearchObject = new KartaSearchObject
            {
                TerminId = _termin.TerminId,
                Aktivan = cbAktivna.Checked
            };
            dgvKarte.DataSource = await _kartaService.Get<List<Karta>>(kartaSearchObject);
        }

        private void btnSjedista_Click(object sender, EventArgs e)
        {
            frmPrikazSjedista frmPrikazSjedista = new frmPrikazSjedista(_termin);
            if (frmPrikazSjedista.ShowDialog() == DialogResult.OK)
            {
                dgvKarte.DataSource = null;
                frmPrikazKarata_Load(sender, e);
            }
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            frmGrafickiPrikazKarata frmGrafickiPrikazKarata = new frmGrafickiPrikazKarata(_termin);
            if (frmGrafickiPrikazKarata.ShowDialog() == DialogResult.OK)
            {
                dgvKarte.DataSource = null;
                frmPrikazKarata_Load(sender, e);
            }
        }
        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati karte? Ne možete poništiti ovu radnju!", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;
            if (result == DialogResult.Yes) { 
                KartaSearchObject kartaSearchObject = new KartaSearchObject
            {
                TerminId = _termin.TerminId
            };
            var list = await _kartaService.Get<List<Karta>>(kartaSearchObject);
            var brojac = list.Where(e => e.Aktivna == false).Count();
                if (brojac != 0)
                {
                    MessageBox.Show("Ne možete obrisati karte, jer su neke već kupljene!",
                                              Resursi.Get(Kljucevi.Informacija),
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        await _kartaService.Delete<Karta>(list[i].KartaId);
                    }
                    dgvKarte.DataSource = null;
                    frmPrikazKarata_Load(sender, e);
                    MessageBox.Show("Uspjesno obrisane!");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
