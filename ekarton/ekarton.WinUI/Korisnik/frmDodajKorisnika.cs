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

namespace ekarton.WinUI.Korisnik
{
    public partial class frmDodajKorisnika : Form
    {
        ApiService _korisnikService = new ApiService("Korisnik");
        ApiService _korisnikUlogaService = new ApiService("KorisnikUloga");
        ApiService _ulogaService = new ApiService("Uloga");

        private Model.Models.Korisnik _korisnik;

        public frmDodajKorisnika(Model.Models.Korisnik korisnik=null)
        {
            InitializeComponent();
            this._korisnik = korisnik;
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


        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(_korisnik==null)
            {
                var newList = new List<int>();
                newList.Add(cmbUloga.SelectedIndex);
                KorisniciInsertRequest request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda = txtPotvrdaLozinke.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text
                };
                bool postojiUsername = false;
                var listakorsnika = await _korisnikService.Get<List<Model.Models.Korisnik>>(null);
                foreach (var item in listakorsnika)
                {
                    if (item.KorisnickoIme.ToLower() == request.KorisnickoIme)
                        postojiUsername = true;
                }
                if (txtPrezime.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "" || txtIme.Text == "" ||
                    txtPotvrdaLozinke.Text == "" || txtLozinka.Text == "" || txtPrezime.Text.Length < 2 || txtIme.Text.Length < 2 || cmbUloga.SelectedIndex == 0)
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
                else if (txtLozinka.Text != txtPotvrdaLozinke.Text || txtLozinka.Text.Length < 4)
                {
                    errorProvider1.SetError(txtLozinka, "Passwordi se ne slazu ili moraju sadrzavati minimalno 4 karaktera.");
                }
                else
                {
                    var korisnik = await _korisnikService.Insert<Model.Models.Korisnik>(request);
                    MessageBox.Show("Uspjesno ste dodali novog korisnika.");
                    Close();
                }
            }
            else
            {
                KorisniciUpdateRequest request = new KorisniciUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda = txtPotvrdaLozinke.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text
                };
                bool postojiUsername = false;
                var listakorsnika = await _korisnikService.Get<List<Model.Models.Korisnik>>(null);
                foreach (var item in listakorsnika)
                {
                    if (item.KorisnickoIme.ToLower() == request.KorisnickoIme && _korisnik.KorisnikId != item.KorisnikId)
                        postojiUsername = true;
                }
                if (txtPrezime.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "" || txtIme.Text == "" ||
                    txtPotvrdaLozinke.Text == "" || txtLozinka.Text == "" || txtPrezime.Text.Length < 2 || txtIme.Text.Length < 2 || cmbUloga.SelectedIndex == 0)
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
                else if (txtLozinka.Text != txtPotvrdaLozinke.Text || txtLozinka.Text.Length < 4)
                {
                    errorProvider1.SetError(txtLozinka, "Passwordi se ne slazu ili moraju sadrzavati minimalno 4 karaktera.");
                }
                else
                {
                    var korisnik = await _korisnikService.Update<Model.Models.Korisnik>(_korisnik.KorisnikId, request);
                    MessageBox.Show("Uspjesno ste editovali postojeceg korisnika.");
                    Close();
                }
            }
        }

        private async Task LoadUloga()
        {
            var result = await _ulogaService.Get<List<Model.Models.Uloga>>();
            result.Insert(0, new Model.Models.Uloga());
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "UlogaId";
            cmbUloga.DataSource = result;
        }

        private async void frmDodajKorisnika_Load(object sender, EventArgs e)
        {
            await LoadUloga();
            if(_korisnik!=null)
            {
                MessageBox.Show($"Korisnik:{_korisnik.Ime}");
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtKorisnickoIme.Text = _korisnik.KorisnickoIme;

            };
            /*var lista = await _korisnikUlogaService.Get<List<Model.Models.KorisnikUloga>>();
            foreach(var item in lista)
            {
                if (_korisnik.KorisnikId == item.KorisnikId)
                    cmbUloga.SelectedIndex = item.UlogaId;
            }*/

        }
    }
}
