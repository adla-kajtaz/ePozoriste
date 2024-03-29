﻿using ePozoriste.Model;
using ePozoriste.Model.Requests;
using ePozoriste.WinUI.Helper;
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
        private int _pozoristeId;

        public frmDodajSalu(int pozoristeId, Sala sala = null)
        {
            InitializeComponent();
            _sala = sala;
            _pozoristeId = pozoristeId; 
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
                }
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
                if (ValidanUnos())
                {
                    SalaInsertRequest salaInsertRequest = new SalaInsertRequest
                    {
                        Naziv = txtNaziv.Text,
                        BrSjedista = Int32.Parse(txtBrSjedista.Text),
                        BrSjedistaPoRedu = Int32.Parse(txtBrSjedistaPoRedu.Text),
                        BrRedova = Int32.Parse(txtBrRedova.Text),
                        PozoristeId = _pozoristeId
                    };

                    if (_sala == null)
                    {
                        var sala = await _salaService.Insert<Sala>(salaInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoDodati),
                                Resursi.Get(Kljucevi.Informacija),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        var sala = await _salaService.Update<Sala>(_sala.SalaId, salaInsertRequest);
                        MessageBox.Show(Resursi.Get(Kljucevi.PodaciUspjesnoModifikovani),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resursi.Get(Kljucevi.Greska),
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            } 
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtNaziv, errNaziv, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtBrSjedista, errSjedista, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajBroj(txtBrSjedista, errSjedista)
                && Validator.ValidirajKontrolu(txtBrRedova, errBrojRedova, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajBroj(txtBrRedova, errBrojRedova)
                && Validator.ValidirajKontrolu(txtBrSjedistaPoRedu, errSjPoRedu, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajBroj(txtBrSjedistaPoRedu, errSjPoRedu);
        }
    }
}
