
namespace ekarton.WinUI.Pacijent
{
    partial class frmPretraga
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPacijent = new System.Windows.Forms.DataGridView();
            this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKartona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prebivaliste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretrazi.Location = new System.Drawing.Point(581, 97);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 7;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(160, 97);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(415, 23);
            this.txtPacijent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime ili prezime pacijenta :";
            // 
            // dgvPacijent
            // 
            this.dgvPacijent.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPacijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacijentId,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.KorisnickoIme,
            this.BrojKartona,
            this.Prebivaliste,
            this.KorisnikId});
            this.dgvPacijent.Location = new System.Drawing.Point(13, 130);
            this.dgvPacijent.Name = "dgvPacijent";
            this.dgvPacijent.RowTemplate.Height = 25;
            this.dgvPacijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacijent.Size = new System.Drawing.Size(643, 150);
            this.dgvPacijent.TabIndex = 4;
            this.dgvPacijent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacijent_CellDoubleClick);
            // 
            // PacijentId
            // 
            this.PacijentId.DataPropertyName = "PacijentId";
            this.PacijentId.HeaderText = "PacijentId";
            this.PacijentId.Name = "PacijentId";
            this.PacijentId.Visible = false;
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
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            // 
            // BrojKartona
            // 
            this.BrojKartona.DataPropertyName = "BrojKartona";
            this.BrojKartona.HeaderText = "Broj kartona";
            this.BrojKartona.Name = "BrojKartona";
            // 
            // Prebivaliste
            // 
            this.Prebivaliste.DataPropertyName = "Prebivaliste";
            this.Prebivaliste.HeaderText = "Prebivaliste";
            this.Prebivaliste.Name = "Prebivaliste";
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.Visible = false;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPacijent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPacijent);
            this.Name = "frmPretraga";
            this.Size = new System.Drawing.Size(677, 370);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPacijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKartona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prebivaliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
    }
}
