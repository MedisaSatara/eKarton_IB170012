
namespace ekarton.WinUI.Nalaz
{
    partial class frmNalaz
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
            this.dgvNalaz = new System.Windows.Forms.DataGridView();
            this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NalazId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorodicnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNalaz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNalaz
            // 
            this.dgvNalaz.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvNalaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNalaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacijentId,
            this.NalazId,
            this.LicnaAnamneza,
            this.PorodicnaAnamneza,
            this.RadnaAnamneza});
            this.dgvNalaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNalaz.Location = new System.Drawing.Point(3, 19);
            this.dgvNalaz.Name = "dgvNalaz";
            this.dgvNalaz.RowTemplate.Height = 25;
            this.dgvNalaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNalaz.Size = new System.Drawing.Size(492, 148);
            this.dgvNalaz.TabIndex = 0;
            // 
            // PacijentId
            // 
            this.PacijentId.DataPropertyName = "PacijentId";
            this.PacijentId.HeaderText = "PacijentId";
            this.PacijentId.Name = "PacijentId";
            this.PacijentId.Visible = false;
            // 
            // NalazId
            // 
            this.NalazId.DataPropertyName = "NalazId";
            this.NalazId.HeaderText = "NalazId";
            this.NalazId.Name = "NalazId";
            this.NalazId.Visible = false;
            // 
            // LicnaAnamneza
            // 
            this.LicnaAnamneza.DataPropertyName = "LicnaAnamneza";
            this.LicnaAnamneza.HeaderText = "Licna anamneza";
            this.LicnaAnamneza.Name = "LicnaAnamneza";
            this.LicnaAnamneza.Width = 150;
            // 
            // PorodicnaAnamneza
            // 
            this.PorodicnaAnamneza.DataPropertyName = "PorodicnaAnamneza";
            this.PorodicnaAnamneza.HeaderText = "Porodicna anamneza";
            this.PorodicnaAnamneza.Name = "PorodicnaAnamneza";
            this.PorodicnaAnamneza.Width = 150;
            // 
            // RadnaAnamneza
            // 
            this.RadnaAnamneza.DataPropertyName = "RadnaAnamneza";
            this.RadnaAnamneza.HeaderText = "Radna anamneza";
            this.RadnaAnamneza.Name = "RadnaAnamneza";
            this.RadnaAnamneza.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNalaz);
            this.groupBox1.Location = new System.Drawing.Point(80, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista nalaza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime pacijenta :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.BackColor = System.Drawing.Color.LightCoral;
            this.txtPacijent.Location = new System.Drawing.Point(83, 114);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(159, 23);
            this.txtPacijent.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretraga.Location = new System.Drawing.Point(248, 114);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // frmNalaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPacijent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNalaz";
            this.Size = new System.Drawing.Size(648, 352);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNalaz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNalaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NalazId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicnaAnamneza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorodicnaAnamneza;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnaAnamneza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Button btnPretraga;
    }
}
