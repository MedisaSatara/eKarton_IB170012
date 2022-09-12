using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekarton.WinUI.Doktor
{
    public partial class frmDoktor : Form
    {
        ApiService _doktorService = new ApiService("Doktor");
        ApiService _odjelService = new ApiService("Odjel");

        public frmDoktor()
        {
            InitializeComponent();
            dgvDoktor.AutoGenerateColumns = false;
        }

        private async void frmDoktor_Load(object sender, EventArgs e)
        {
            await LoadDoktor();
        }

        private async void btnOdjel_Click(object sender, EventArgs e)
        {
            DoktorSearchRequest request = new DoktorSearchRequest()
            {
                NazivOdjela = txtOdjel.Text
            };
            var item = await _doktorService.Get<List<Model.Models.Doktor>>(request);
            dgvDoktor.DataSource = item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDodajUrediDoktora frm = new frmDodajUrediDoktora();
            frm.ShowDialog();
        }

        /*private async void dgvDoktor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private async Task LoadDoktor()
        {
            var item = await _doktorService.Get<List<Model.Models.Doktor>>(null);
            dgvDoktor.DataSource = item;
        }
    }
}
