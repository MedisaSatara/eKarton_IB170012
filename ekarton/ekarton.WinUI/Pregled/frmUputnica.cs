using ekarton.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Pregled
{
    public partial class frmUputnica : Form
    {
        private Uputnica u;
        ApiService _pregledService = new ApiService("Pregled");
        ApiService _pacijentService = new ApiService("Pacijent");



        public frmUputnica(Uputnica u)
        {
            InitializeComponent();
            this.u = u;
        }

        private async void frmUputnica_Load(object sender, EventArgs e)
        {
            var item = await _pregledService.Get<List<Model.Models.Pregled>>(null);
            var pacijent = await _pacijentService.Get<List<Model.Models.Pacijent>>(null);


            if (u!=null)
            {
                foreach(var pregled in item)
                {
                    foreach(var p in pacijent)
                    {
                        if(pregled.PacijentId==p.PacijentId)
                            txtPacijent.Text = p.Ime;
                    }

                }
                txtDatum.Text = u.Datum.ToString();
                txtNaziv.Text = u.Naziv;
                txtRazlog.Text = u.Razlog;
            }
        }
    }
}
