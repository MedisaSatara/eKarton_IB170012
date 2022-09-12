using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Pacijent
{
    public partial class frmOsiguranje : UserControl
    {
        ApiService _osiguranjeService = new ApiService("Osiguranje");
        ApiService _pacijentOsiguranjeService = new ApiService("PacijentOsiguranje");
        ApiService _pacijentService = new ApiService("Pacijent");


        public frmOsiguranje()
        {
            InitializeComponent();
            //dgvOsiguranje.AutoGenerateColumns = false;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            PacijentOsiguranjeSearchRequest request = new PacijentOsiguranjeSearchRequest()
            {
                ImePacijenta = txtPacijent.Text
            };
            var item =await _pacijentOsiguranjeService.Get<List<Model.Models.PacijentOsiguranje>>(request);
            //dgvOsiguranje.DataSource = item;
            var osiguranje = await _osiguranjeService.Get<List<Model.Models.Osiguranje>>(request);
            var pacijent = await _pacijentService.Get<List<Model.Models.Pacijent>>(request);

            foreach (var osiguranja in item)
            {
                if(osiguranja.OsiguranjeId!=0)
                {
                    foreach(var o in osiguranje)
                    {
                        foreach (var p in pacijent)
                        {
                            if (osiguranja.PacijentId == p.PacijentId)
                            { lblPacijent.Text = p.Ime + " " + p.Prezime; }
                        }
                        if(osiguranja.OsiguranjeId==o.OsiguranjeId)
                        {
                            txtOsiguranik.Text = o.Osiguranik;
                            txtDatum.Text = osiguranja.DatumOsiguranja.ToString();
                            cbVazece.Checked = osiguranja.Vazece;
                        }
                    }
                }
            }
        }
    }
}
