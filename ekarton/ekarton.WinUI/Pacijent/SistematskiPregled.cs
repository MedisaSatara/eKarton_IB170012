using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Pacijent
{
    public partial class SistematskiPregled : Form
    {
        private Model.Models.Pacijent pacijent;
        ApiService _sistematskiPregledService = new ApiService("SistematskiPregled");
        public SistematskiPregled(Model.Models.Pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            dgvSistematskiPregled.AutoGenerateColumns = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void SistematskiPregled_Load(object sender, EventArgs e)
        {
            if (pacijent != null)
            {
                var item = await _sistematskiPregledService.Get<List<Model.Models.SistematskiPregled>>(pacijent);
                dgvSistematskiPregled.DataSource = item;
                foreach (var pregled in item)
                {
                    lblPacijent.Text = pacijent.Ime + " " + pacijent.Prezime;
                    lblDatum.Text = pregled.Datum.ToString();
                    txtAbdomen.Text = pregled.Abdomen;
                    txtBMI.Text = pregled.Bmi.ToString();
                    txtCula.Text = pregled.Cula;
                    txtGrudniKos.Text = pregled.GrudniKos;
                    txtKicmeniStub.Text = pregled.KicmeniStub;
                    txtKrvniPritisak.Text = pregled.KrvniPritisak;
                    txtObimGrudi.Text = pregled.ObimGrudi;
                    txtObimSturka.Text = pregled.ObimStruka;
                    txtPluca.Text = pregled.Pluca;
                    txtPromjeneNaKozi.Text = pregled.PromjeneNaKozi;
                    txtPuls.Text = pregled.Puls;
                    txtTezina.Text = pregled.Tezina;
                    txtTonzile.Text = pregled.Tonzile;
                    txtVisina.Text = pregled.Visina.ToString();
                    txtVrat.Text = pregled.Vrat;
                }
            }
        }
    }
}
