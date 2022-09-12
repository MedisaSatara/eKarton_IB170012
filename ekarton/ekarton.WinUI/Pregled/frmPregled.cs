using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Pregled
{
    public partial class frmPregled : Form
    {
        ApiService _pregledService = new ApiService("Pregled");
        ApiService _terapijaService = new ApiService("Terapija");
        ApiService _uputnicaService = new ApiService("Uputnica");


        private Model.Models.Pacijent pacijent;
        private int pacijentId;


        public frmPregled()
        {
            InitializeComponent();
            dgvPregled.AutoGenerateColumns = false;
        }

        private async void frmPregled_Load(object sender, EventArgs e)
        {
               // var item =await _pregledService.Get<List<Model.Models.Pregled>>(null);
               // dgvPregled.DataSource = item;
            
                
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            PregledSearchRequest request = new PregledSearchRequest()
            {
                ImePacijenta = txtPacijent.Text
            };
            var item = await _pregledService.Get<List<Model.Models.Pregled>>(request);
            dgvPregled.DataSource = item;
            var terapija = await _terapijaService.Get<List<Model.Models.Terapija>>(request);
            //dgvPregled.DataSource = terapija;
            foreach(var pregled in item)
            {
                if(pregled.TerapijaId!=0)
                {
                    foreach (var t in terapija)
                    {
                        txtNazivLijeka.Text = t.NazivLijekova;
                        txtUpute.Text = t.Uputa;
                        txtPodsjetnik.Text = t.Podsjetnik;
                        txtDatumOd.Text = t.Od.ToString();
                        txtDatumDO.Text = t.Do.ToString();
                    }
                }
            }
        }

        private async void dgvPregled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PregledSearchRequest request = new PregledSearchRequest()
            {
                ImePacijenta = txtPacijent.Text
            };
            var item = await _pregledService.Get<List<Model.Models.Pregled>>(request);
            var uputnica = await _uputnicaService.Get<List<Model.Models.Uputnica>>(request);
            foreach(var pregled in item)
            {
                if(pregled.UputnicaId!=0)
                {
                    foreach(var u in uputnica)
                    {
                        frmUputnica frm = new frmUputnica(u);
                        frm.ShowDialog();
                    }
                }
            }

        }
    }
}
