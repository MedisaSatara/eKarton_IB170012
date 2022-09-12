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
    public partial class frmPacijentDetalji : Form
    {
        ApiService _pacijentService = new ApiService("Pacijent");
        private Model.Models.Pacijent _pacijent;
        ApiService _pacijentOsiguranjeService = new ApiService("PacijentOsiguranje");
        ApiService _osiguranjeService = new ApiService("Osiguranje");
        ApiService _preventivneMjereService = new ApiService("PreventivneMjere");



        public frmPacijentDetalji(Model.Models.Pacijent pacijent)
        {
            InitializeComponent();
            this._pacijent = pacijent;
        }
        /*private async Task LoadOsiguranje()
        {
            var result = await _osiguranjeService.Get<List<Model.Models.Osiguranje>>();
            result.Insert(0, new Model.Models.Osiguranje());
            cmbOsiguranje.DisplayMember = "Osiguranik";
            cmbOsiguranje.ValueMember = "OsiguranjeId";
            cmbOsiguranje.DataSource = result;

        }*/
        private async void frmPacijentDetalji_Load(object sender, EventArgs e)
        {
            //await LoadOsiguranje();
            if(_pacijent!=null)
            {
                MessageBox.Show($"Pacijent : {_pacijent.Ime}");
                lblPacijent.Text = _pacijent.Ime + " " + _pacijent.Prezime;
                txtSpol.Text = _pacijent.Spol;
                txtDatumRodjenja.Text = _pacijent.DatumRodjenja;
                txtMjestoRodjenja.Text = _pacijent.MjestoRodjenja;
                txtPRebivaliste.Text = _pacijent.Prebivaliste;
                txtTelefon.Text = _pacijent.Telefon;
                txtJmbg.Text = _pacijent.Jmbg.ToString();
                txtAlergican.Text = _pacijent.Alergican;
                txtHronicneBolesti.Text = _pacijent.HronicneBolesti;
                txtKoagulopatija.Text = _pacijent.Koagulopatije.ToString();
                txtRhFaktor.Text = _pacijent.RhFaktor;
                txtKrvnaGrupa.Text = _pacijent.KrvnaGrupa;
                txtKorisnickoIme.Text = _pacijent.KorisnickoIme;
                lblBrojKartona.Text = _pacijent.BrojKartona;
            }
        }

        private async void btnPreventivneMjere_Click(object sender, EventArgs e)
        {
            if(_pacijent!=null)
            {
                var preventivneMjere =await _preventivneMjereService.Get<List<Model.Models.PreventivneMjere>>(_pacijent);
                var listaPacijenata = await _pacijentService.Get<List<Model.Models.Pacijent>>(_pacijent);

                foreach (var mjere in preventivneMjere)
                {
                    if(mjere.PacijentId!=0)
                    {
                        foreach(var pacijent in listaPacijenata)
                        {
                            if(mjere.PacijentId==pacijent.PacijentId)
                            {
                                frmPreventivneMjere frm = new frmPreventivneMjere(mjere);
                                frm.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void btnSistematskiPregled_Click(object sender, EventArgs e)
        {
            SistematskiPregled frm = new SistematskiPregled(_pacijent);
            frm.ShowDialog();
        }
    }
}
