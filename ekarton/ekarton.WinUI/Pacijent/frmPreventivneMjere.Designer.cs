
namespace ekarton.WinUI.Pacijent
{
    partial class frmPreventivneMjere
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
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.dgvPreventivneMjere = new System.Windows.Forms.DataGridView();
            this.MjereId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPacijent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventivneMjere)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(73, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stanje";
            // 
            // txtStanje
            // 
            this.txtStanje.BackColor = System.Drawing.Color.LightCoral;
            this.txtStanje.Location = new System.Drawing.Point(128, 94);
            this.txtStanje.Multiline = true;
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(200, 53);
            this.txtStanje.TabIndex = 1;
            // 
            // dgvPreventivneMjere
            // 
            this.dgvPreventivneMjere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreventivneMjere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MjereId,
            this.Stanje,
            this.PacijentId});
            this.dgvPreventivneMjere.Location = new System.Drawing.Point(407, 118);
            this.dgvPreventivneMjere.Name = "dgvPreventivneMjere";
            this.dgvPreventivneMjere.RowTemplate.Height = 25;
            this.dgvPreventivneMjere.Size = new System.Drawing.Size(339, 145);
            this.dgvPreventivneMjere.TabIndex = 4;
            // 
            // MjereId
            // 
            this.MjereId.DataPropertyName = "MjereId";
            this.MjereId.HeaderText = "MjereId";
            this.MjereId.Name = "MjereId";
            // 
            // Stanje
            // 
            this.Stanje.DataPropertyName = "Stanje";
            this.Stanje.HeaderText = "Stanje";
            this.Stanje.Name = "Stanje";
            // 
            // PacijentId
            // 
            this.PacijentId.DataPropertyName = "PacijentId";
            this.PacijentId.HeaderText = "PacijentId";
            this.PacijentId.Name = "PacijentId";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Location = new System.Drawing.Point(73, 153);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(255, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj preventivne mjere";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preventivne mjere za pacijenta :";
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.BackColor = System.Drawing.Color.Snow;
            this.lblPacijent.Location = new System.Drawing.Point(229, 44);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(39, 15);
            this.lblPacijent.TabIndex = 7;
            this.lblPacijent.Text = "Stanje";
            // 
            // frmPreventivneMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(406, 240);
            this.Controls.Add(this.lblPacijent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPreventivneMjere);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.label1);
            this.Name = "frmPreventivneMjere";
            this.Text = "frmPreventivneMjere";
            this.Load += new System.EventHandler(this.frmPreventivneMjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventivneMjere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.DataGridView dgvPreventivneMjere;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjereId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPacijent;
    }
}