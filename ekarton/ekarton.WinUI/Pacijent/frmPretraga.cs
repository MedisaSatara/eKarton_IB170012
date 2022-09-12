using ekarton.Model.Request;
using ekarton.WinUI.Nalaz;
using ekarton.WinUI.Pregled;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekarton.WinUI.Pacijent
{
    public partial class frmPretraga : UserControl
    {
        ApiService _pacijentService = new ApiService("Pacijent");
        ApiService _nalazService = new ApiService("Nalaz");
        ApiService _osiguranjeService = new ApiService("Osiguranje");
        ApiService _osiguranjePacijentService = new ApiService("PacijentOsiguranje");




        public frmPretraga()
        {
            InitializeComponent();
            dgvPacijent.AutoGenerateColumns = false;

        }
        private async Task LoadPacijent()
        {
            dgvPacijent.DataSource = await _pacijentService.Get<List<Model.Models.Pacijent>>(null);
        }
        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            PacijentSearchRequest request = new PacijentSearchRequest()
            {
                Ime = txtPacijent.Text
                //Prezime = txtPacijent.Text
            };
            var listaPacijenata = await _pacijentService.Get<List<Model.Models.Pacijent>>(request);
            dgvPacijent.DataSource = listaPacijenata;
            /*var osiguranjePacijent = await _osiguranjePacijentService.Get<List<Model.Models.PacijentOsiguranje>>(request);
            var osiguranje = await _osiguranjeService.Get<List<Model.Models.Osiguranje>>(request);

            foreach (var osiguranja in osiguranjePacijent)
            {
                if(osiguranja.OsiguranjeId!=0)
                {
                    foreach(var o in osiguranje)
                    {
                        txtOsiguranik.Text = o.Osiguranik;
                        
                    }
                    txtDatum.Text = osiguranja.DatumOsiguranja.ToString();
                    cbVazece.Checked = osiguranja.Vazece;
                }
            }*/

        }

        private void dgvPacijent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvPacijent.SelectedRows[0].DataBoundItem;
            frmPacijentDetalji frm = new frmPacijentDetalji(item as Model.Models.Pacijent);
            frm.ShowDialog();
        }
    }
}
