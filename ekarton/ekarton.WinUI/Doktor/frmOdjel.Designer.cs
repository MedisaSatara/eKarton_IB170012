
namespace ekarton.WinUI.Doktor
{
    partial class frmOdjel
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOdjel = new System.Windows.Forms.DataGridView();
            this.OdjelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivOdjela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacije o odjelima";
            // 
            // dgvOdjel
            // 
            this.dgvOdjel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdjel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdjelId,
            this.NazivOdjela,
            this.Telefon});
            this.dgvOdjel.Location = new System.Drawing.Point(88, 66);
            this.dgvOdjel.Name = "dgvOdjel";
            this.dgvOdjel.RowTemplate.Height = 25;
            this.dgvOdjel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdjel.Size = new System.Drawing.Size(283, 126);
            this.dgvOdjel.TabIndex = 1;
            this.dgvOdjel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdjel_CellDoubleClick);
            // 
            // OdjelId
            // 
            this.OdjelId.DataPropertyName = "OdjelId";
            this.OdjelId.HeaderText = "OdjelId";
            this.OdjelId.Name = "OdjelId";
            this.OdjelId.Visible = false;
            // 
            // NazivOdjela
            // 
            this.NazivOdjela.DataPropertyName = "NazivOdjela";
            this.NazivOdjela.HeaderText = "NazivOdjela";
            this.NazivOdjela.Name = "NazivOdjela";
            this.NazivOdjela.Width = 140;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // btnDodaj
            // 
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Location = new System.Drawing.Point(88, 199);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(283, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj odjel";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmOdjel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 286);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvOdjel);
            this.Controls.Add(this.label1);
            this.Name = "frmOdjel";
            this.Text = "frmOdjel";
            this.Load += new System.EventHandler(this.frmOdjel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOdjel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdjelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivOdjela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.Button btnDodaj;
    }
}