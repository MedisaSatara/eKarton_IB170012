using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Doktor
{
    public partial class frmDodajUrediOdjel : Form
    {
        ApiService _odjelServic = new ApiService("Odjel");
        private Model.Models.Odjel _odjel;
        public frmDodajUrediOdjel()
        {
            InitializeComponent();
        }
        public frmDodajUrediOdjel(Model.Models.Odjel _odjel)
        {
            InitializeComponent();
            this._odjel = _odjel;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(_odjel!=null)
            {
                OdjelUpdateRequest request = new OdjelUpdateRequest()
                {
                    Naziv = txtNazivOdjela.Text,
                    Telefon = txtBrojTelefona.Text
                };
                var item =await _odjelServic.Get<List<Model.Models.Odjel>>(request);
                MessageBox.Show("Uspjesno ste uredili informacije vec postojeceg odjela !");
                Close();
                

            }
            else
            {
                OdjelInsertRequest request = new OdjelInsertRequest()
                {
                    Naziv = txtNazivOdjela.Text,
                    Telefon = txtBrojTelefona.Text
                };
                var item = await _odjelServic.Get<List<Model.Models.Odjel>>(request);
                MessageBox.Show("Uspjesno ste dodali novi odjel !");
                Close();

            }
        }
    }
}
