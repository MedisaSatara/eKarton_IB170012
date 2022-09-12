
namespace ekarton.WinUI.Doktor
{
    partial class frmDoktor
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
            this.dgvDoktor = new System.Windows.Forms.DataGridView();
            this.DoktorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdjelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdjel = new System.Windows.Forms.TextBox();
            this.btnOdjel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoktor
            // 
            this.dgvDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoktor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoktorId,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.Spol,
            this.Jmbg,
            this.Grad,
            this.Telefon,
            this.Email,
            this.OdjelId});
            this.dgvDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoktor.Location = new System.Drawing.Point(3, 19);
            this.dgvDoktor.Name = "dgvDoktor";
            this.dgvDoktor.RowTemplate.Height = 25;
            this.dgvDoktor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoktor.Size = new System.Drawing.Size(842, 176);
            this.dgvDoktor.TabIndex = 0;
            // 
            // DoktorId
            // 
            this.DoktorId.DataPropertyName = "DoktorId";
            this.DoktorId.HeaderText = "DoktorId";
            this.DoktorId.Name = "DoktorId";
            this.DoktorId.Visible = false;
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
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            // 
            // Jmbg
            // 
            this.Jmbg.DataPropertyName = "Jmbg";
            this.Jmbg.HeaderText = "Jmbg";
            this.Jmbg.Name = "Jmbg";
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // OdjelId
            // 
            this.OdjelId.DataPropertyName = "OdjelId";
            this.OdjelId.HeaderText = "OdjelId";
            this.OdjelId.Name = "OdjelId";
            this.OdjelId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv odjela :";
            // 
            // txtOdjel
            // 
            this.txtOdjel.Location = new System.Drawing.Point(98, 75);
            this.txtOdjel.Name = "txtOdjel";
            this.txtOdjel.Size = new System.Drawing.Size(497, 23);
            this.txtOdjel.TabIndex = 2;
            // 
            // btnOdjel
            // 
            this.btnOdjel.BackColor = System.Drawing.Color.White;
            this.btnOdjel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjel.Location = new System.Drawing.Point(601, 74);
            this.btnOdjel.Name = "btnOdjel";
            this.btnOdjel.Size = new System.Drawing.Size(125, 23);
            this.btnOdjel.TabIndex = 3;
            this.btnOdjel.Text = "Pretrazi po odjelu";
            this.btnOdjel.UseVisualStyleBackColor = false;
            this.btnOdjel.Click += new System.EventHandler(this.btnOdjel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoktor);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista doktora";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(732, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj doktora ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ekarton.WinUI.Properties.Resources.medical_563427_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdjel);
            this.Controls.Add(this.txtOdjel);
            this.Controls.Add(this.label1);
            this.Name = "frmDoktor";
            this.Text = "frmDoktor";
            this.Load += new System.EventHandler(this.frmDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jmbg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdjelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdjel;
        private System.Windows.Forms.Button btnOdjel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}