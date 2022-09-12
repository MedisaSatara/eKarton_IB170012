
namespace ekarton.WinUI.Korisnik
{
    partial class frmKorisnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKorisnik = new System.Windows.Forms.DataGridView();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LozinkaSalt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LozinkaHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnik
            // 
            this.dgvKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.LozinkaSalt,
            this.LozinkaHash});
            this.dgvKorisnik.Location = new System.Drawing.Point(100, 120);
            this.dgvKorisnik.Name = "dgvKorisnik";
            this.dgvKorisnik.RowTemplate.Height = 25;
            this.dgvKorisnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnik.Size = new System.Drawing.Size(344, 150);
            this.dgvKorisnik.TabIndex = 1;
            this.dgvKorisnik.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnik_CellDoubleClick);
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            // 
            // LozinkaSalt
            // 
            this.LozinkaSalt.DataPropertyName = "LozinkaSalt";
            this.LozinkaSalt.HeaderText = "LozinkaSalt";
            this.LozinkaSalt.Name = "LozinkaSalt";
            this.LozinkaSalt.Visible = false;
            // 
            // LozinkaHash
            // 
            this.LozinkaHash.DataPropertyName = "LozinkaHash";
            this.LozinkaHash.HeaderText = "LozinkaHash";
            this.LozinkaHash.Name = "LozinkaHash";
            this.LozinkaHash.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Snow;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Location = new System.Drawing.Point(100, 276);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(344, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(100, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime korisnika :";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(100, 90);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(258, 23);
            this.txtKorisnik.TabIndex = 4;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.Snow;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretraga.Location = new System.Drawing.Point(365, 90);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(79, 23);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // frmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::ekarton.WinUI.Properties.Resources.kisspng_laptop_user_computer_icons_clip_art_user_cliparts_5aabde1a1f5266_2438057215212129541283;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 339);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvKorisnik);
            this.Name = "frmKorisnik";
            this.Text = "frmKorisnik";
            this.Load += new System.EventHandler(this.frmKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn LozinkaSalt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LozinkaHash;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Button btnPretraga;
    }
}