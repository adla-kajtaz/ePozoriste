﻿using ePozoriste.Model;
using ePozoriste.Model.Requests;
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
    public partial class frmDodajSalu : Form
    {
        APIService _salaService { get; set; } = new APIService("Sala");
        APIService _pozoristeService { get; set; } = new APIService("Pozoriste");
        private Sala _sala;

        public frmDodajSalu(Sala sala = null)
        {
            InitializeComponent();
            _sala = sala;
            UcitajPozorista();
        }

        private async void frmDodajSalu_Load(object sender, EventArgs e)
        {
            try
            {
                if (_sala != null)
                {
                    txtNaziv.Text = _sala.Naziv;
                    txtBrSjedista.Text = _sala.BrSjedista.ToString();
                    txtBrSjedistaPoRedu.Text = _sala.BrSjedistaPoRedu.ToString();
                    txtBrRedova.Text = _sala.BrRedova.ToString();
                    cmbPozorista.SelectedValue = _sala.PozoristeId;
                }
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

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                SalaInsertRequest salaInsertRequest = new SalaInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    BrSjedista = Int32.Parse(txtBrSjedista.Text),
                    BrSjedistaPoRedu = Int32.Parse(txtBrSjedistaPoRedu.Text),
                    BrRedova = Int32.Parse(txtBrRedova.Text),
                    PozoristeId = (int)cmbPozorista.SelectedValue
                };

                if (_sala == null)
                {
                    var sala = await _salaService.Insert<Sala>(salaInsertRequest);
                }
                else
                {
                    var sala = await _salaService.Update<Sala>(_sala.SalaId, salaInsertRequest);
                }
                MessageBox.Show("Uspjesno sacuvano");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska");
            }
        }
    }
}
