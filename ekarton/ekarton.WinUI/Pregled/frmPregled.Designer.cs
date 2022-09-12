
namespace ekarton.WinUI.Pregled
{
    partial class frmPregled
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
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.PregledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazlogPosjete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dijagnoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UputnicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerapijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpute = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPodsjetnik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatumDO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazivLijeka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPregled
            // 
            this.dgvPregled.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PregledId,
            this.Datum,
            this.RazlogPosjete,
            this.Dijagnoza,
            this.PacijentId,
            this.UputnicaId,
            this.TerapijaId});
            this.dgvPregled.Location = new System.Drawing.Point(91, 129);
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.RowTemplate.Height = 25;
            this.dgvPregled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregled.Size = new System.Drawing.Size(342, 127);
            this.dgvPregled.TabIndex = 0;
            this.dgvPregled.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregled_CellContentClick);
            // 
            // PregledId
            // 
            this.PregledId.DataPropertyName = "PregledId";
            this.PregledId.HeaderText = "PregledId";
            this.PregledId.Name = "PregledId";
            this.PregledId.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // RazlogPosjete
            // 
            this.RazlogPosjete.DataPropertyName = "RazlogPosjete";
            this.RazlogPosjete.HeaderText = "RazlogPosjete";
            this.RazlogPosjete.Name = "RazlogPosjete";
            // 
            // Dijagnoza
            // 
            this.Dijagnoza.DataPropertyName = "Dijagnoza";
            this.Dijagnoza.HeaderText = "Dijagnoza";
            this.Dijagnoza.Name = "Dijagnoza";
            // 
            // PacijentId
            // 
            this.PacijentId.DataPropertyName = "PacijentId";
            this.PacijentId.HeaderText = "PacijentId";
            this.PacijentId.Name = "PacijentId";
            this.PacijentId.Visible = false;
            // 
            // UputnicaId
            // 
            this.UputnicaId.DataPropertyName = "UputnicaId";
            this.UputnicaId.HeaderText = "UputnicaId";
            this.UputnicaId.Name = "UputnicaId";
            this.UputnicaId.Visible = false;
            // 
            // TerapijaId
            // 
            this.TerapijaId.DataPropertyName = "TerapijaId";
            this.TerapijaId.HeaderText = "TerapijaId";
            this.TerapijaId.Name = "TerapijaId";
            this.TerapijaId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi ime pacijenta :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(23, 49);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(223, 23);
            this.txtPacijent.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnPretraga);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPacijent);
            this.groupBox1.Location = new System.Drawing.Point(91, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po pacijentu";
            // 
            // btnPretraga
            // 
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretraga.Location = new System.Drawing.Point(252, 48);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.txtUpute);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPodsjetnik);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDatumDO);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDatumOd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNazivLijeka);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(91, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 182);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terapija po pregledu";
            // 
            // txtUpute
            // 
            this.txtUpute.Location = new System.Drawing.Point(113, 55);
            this.txtUpute.Name = "txtUpute";
            this.txtUpute.Size = new System.Drawing.Size(214, 23);
            this.txtUpute.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Upute :";
            // 
            // txtPodsjetnik
            // 
            this.txtPodsjetnik.Location = new System.Drawing.Point(113, 141);
            this.txtPodsjetnik.Name = "txtPodsjetnik";
            this.txtPodsjetnik.Size = new System.Drawing.Size(214, 23);
            this.txtPodsjetnik.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Podsjetnik :";
            // 
            // txtDatumDO
            // 
            this.txtDatumDO.Location = new System.Drawing.Point(113, 112);
            this.txtDatumDO.Name = "txtDatumDO";
            this.txtDatumDO.Size = new System.Drawing.Size(214, 23);
            this.txtDatumDO.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Do :";
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Location = new System.Drawing.Point(113, 83);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.Size = new System.Drawing.Size(214, 23);
            this.txtDatumOd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Od :";
            // 
            // txtNazivLijeka
            // 
            this.txtNazivLijeka.Location = new System.Drawing.Point(113, 26);
            this.txtNazivLijeka.Name = "txtNazivLijeka";
            this.txtNazivLijeka.Size = new System.Drawing.Size(214, 23);
            this.txtNazivLijeka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv lijeka :";
            // 
            // frmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPregled);
            this.Name = "frmPregled";
            this.Text = "frmPregled";
            this.Load += new System.EventHandler(this.frmPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn PregledId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazlogPosjete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dijagnoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UputnicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerapijaId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNazivLijeka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPodsjetnik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatumDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatumOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpute;
        private System.Windows.Forms.Label label6;
    }
}