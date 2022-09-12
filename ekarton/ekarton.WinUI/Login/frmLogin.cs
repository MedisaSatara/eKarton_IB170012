using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly ApiService _api = new ApiService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
        }

        private async void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            ApiService.Username = txtKorisnickoIme.Text;
            ApiService.Password = txtLozinka.Text;

            try
            {
                var result =await _api.Get<List<Model.Models.Korisnik>>();
                frmPocetnaKorisnik frm = new frmPocetnaKorisnik();
                frm.Show();
            }
            catch
            {
                MessageBox.Show("Pogresan username ili password");
            }


        }
    }
}
