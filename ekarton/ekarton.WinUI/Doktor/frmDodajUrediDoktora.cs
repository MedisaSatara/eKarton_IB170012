using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekarton.WinUI.Doktor
{
    public partial class frmDodajUrediDoktora : Form
    {
        ApiService _doktorService = new ApiService("Doktor");
        ApiService _odjelService = new ApiService("Odjel");

        private Model.Models.Doktor _doktor;

        public frmDodajUrediDoktora()
        {
        }
        public frmDodajUrediDoktora(Model.Models.Doktor _doktor)
        {
            InitializeComponent();

            this._doktor = _doktor;
        }

       

        private async Task LoadOdjel()
        {
            var result = await _odjelService.Get<List<Model.Models.Uloga>>();
            result.Insert(0, new Model.Models.Uloga());
            cmbOdjel.DisplayMember = "Naziv";
            cmbOdjel.ValueMember = "OdjelId";
            cmbOdjel.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            await LoadOdjel();
            if (_doktor == null)
            {
                var newList = new List<int>();
                newList.Add(cmbOdjel.SelectedIndex);
                DoktorInsertRequest request = new DoktorInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Spol = txtSpol.Text,
                    Grad = txtGrad.Text,
                    DatumRodjenja = txtDatumRodjenja.Text,
                    Jmbg = txtJmbg.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text
                };
                bool postojiUsername = false;
                var listakorsnika = await _doktorService.Get<List<Model.Models.Doktor>>(null);
                foreach (var item in listakorsnika)
                {
                    if (item.Ime.ToLower() == request.Ime && item.Prezime.ToLower()==request.Prezime)
                        postojiUsername = true;
                }
                if (txtPrezime.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "" || txtIme.Text == "" ||
                     txtPrezime.Text.Length < 2 || txtIme.Text.Length < 2 || cmbOdjel.SelectedIndex == 0)
                {
                    MessageBox.Show("Niste unijeli sva polja ispravno. Pokusajte ponovo. (Polje prazno/ne sadrzi dovoljan broj karaktera)");
                }
                else if (!IsValidEmailAddress(txtEmail.Text))
                {
                    MessageBox.Show("Format emaila nije validan. ->primjer@email.com");
                }
                else if (ValidateContact(txtTelefon.Text) || txtTelefon.Text.Length > 12 || txtTelefon.Text.Length < 11)
                {
                    errorProvider1.SetError(txtTelefon, "Broj nije validan. Unesite 9 ili 10tocifreni broj bez karaktera-> 062963147");
                }
                else
                {
                    var korisnik = await _doktorService.Insert<Model.Models.Doktor>(request);
                    MessageBox.Show("Uspjesno ste dodali novog korisnika.");
                    Close();
                }
            }
            else
            {
                DoktorUpdateRequest request = new DoktorUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Spol = txtSpol.Text,
                    DatumRodjenja = txtDatumRodjenja.Text,
                    Grad = txtGrad.Text,
                    Jmbg = txtJmbg.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text
                };
                bool postojiUsername = false;
                var listakorsnika = await _doktorService.Get<List<Model.Models.Doktor>>(null);
                if (cmbOdjel.SelectedIndex == 0)
                {
                    MessageBox.Show("Niste unijeli sva polja ispravno. Pokusajte ponovo. (Polje prazno/ne sadrzi dovoljan broj karaktera)");
                }
                else if (!IsValidEmailAddress(txtEmail.Text))
                {
                    MessageBox.Show("Format emaila nije validan. ->primjer@email.com");
                }
                else if (ValidateContact(txtTelefon.Text) || txtTelefon.Text.Length > 12 || txtTelefon.Text.Length < 11)
                {
                    errorProvider1.SetError(txtTelefon, "Broj nije validan. Unesite 9 ili 10tocifreni broj bez karaktera-> 062963147");
                }
                else
                {
                    var korisnik = await _doktorService.Update<Model.Models.Korisnik>(_doktor.DoktorId, request);
                    MessageBox.Show("Uspjesno ste editovali postojeceg korisnika.");
                    Close();
                }
            }
        }

        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool ValidateContact(string broj)
        {
            return (System.Text.RegularExpressions.Regex.IsMatch("[^0-9]", broj));
        }

        private async void frmDodajUrediDoktora_Load(object sender, EventArgs e)
        {
            await LoadOdjel();
            if(_doktor!=null)
            {
                MessageBox.Show($"Korisnik:{_doktor.Ime}");
                txtIme.Text = _doktor.Ime;
                txtPrezime.Text = _doktor.Prezime;
                txtSpol.Text = _doktor.Spol;
                txtDatumRodjenja.Text = _doktor.DatumRodjenja;
                txtJmbg.Text = _doktor.Jmbg;
                txtGrad.Text = _doktor.Grad;
                txtTelefon.Text = _doktor.Telefon;
                txtEmail.Text = _doktor.Email;

            };
        }
    }
}
