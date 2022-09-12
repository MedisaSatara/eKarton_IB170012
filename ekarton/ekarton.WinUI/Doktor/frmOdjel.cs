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
    public partial class frmOdjel : Form
    {
        ApiService _odjelService = new ApiService("Odjel");
        public frmOdjel()
        {
            InitializeComponent();
            dgvOdjel.AutoGenerateColumns = false;
        }
        private async Task LoadOdjel()
        {
            var item = await _odjelService.Get<List<Model.Models.Odjel>>(null);
            dgvOdjel.DataSource = item;
        }
        private async void frmOdjel_Load(object sender, EventArgs e)
        {
            await LoadOdjel();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajUrediOdjel frm = new frmDodajUrediOdjel();
            frm.ShowDialog();
        }

        private void dgvOdjel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvOdjel.SelectedRows[0].DataBoundItem;
            frmDodajUrediOdjel frm = new frmDodajUrediOdjel(item as Model.Models.Odjel);
            frm.ShowDialog();
        }
    }
}
