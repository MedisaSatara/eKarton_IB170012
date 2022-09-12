using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekarton.WinUI.Korisnik
{
    public partial class frmKorisnik : Form
    {
        ApiService _korisnikService = new ApiService("Korisnik");
        public frmKorisnik()
        {
            InitializeComponent();
            dgvKorisnik.AutoGenerateColumns = false;
        }
        private async Task LoadKorisnik()
        {
            dgvKorisnik.DataSource = await _korisnikService.Get<List<Model.Models.Korisnik>> (null);
        }
        private void frmKorisnik_Load(object sender, EventArgs e)
        {
            //await LoadKorisnik();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika frm = new frmDodajKorisnika();
            frm.ShowDialog();
            await LoadKorisnik();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KorisnikSearchRequest request = new KorisnikSearchRequest()
            {
                Ime = txtKorisnik.Text
            };
            var item = await _korisnikService.Get<List<Model.Models.Korisnik>>(request);
            dgvKorisnik.DataSource = item;
        }

        private async void dgvKorisnik_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnik.SelectedRows[0].DataBoundItem;
            frmDodajKorisnika frm = new frmDodajKorisnika(item as Model.Models.Korisnik);
            frm.Show();
            await LoadKorisnik();
        }
    }
}
