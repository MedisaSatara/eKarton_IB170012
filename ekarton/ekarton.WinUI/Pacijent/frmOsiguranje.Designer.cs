
namespace ekarton.WinUI.Pacijent
{
    partial class frmOsiguranje
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
            this.cbVazece = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOsiguranik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblPacijent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVazece
            // 
            this.cbVazece.AutoSize = true;
            this.cbVazece.BackColor = System.Drawing.Color.Snow;
            this.cbVazece.Location = new System.Drawing.Point(142, 164);
            this.cbVazece.Name = "cbVazece";
            this.cbVazece.Size = new System.Drawing.Size(61, 19);
            this.cbVazece.TabIndex = 21;
            this.cbVazece.Text = "Vazece";
            this.cbVazece.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(63, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Osiguranik";
            // 
            // txtOsiguranik
            // 
            this.txtOsiguranik.BackColor = System.Drawing.Color.Snow;
            this.txtOsiguranik.Location = new System.Drawing.Point(142, 106);
            this.txtOsiguranik.Name = "txtOsiguranik";
            this.txtOsiguranik.Size = new System.Drawing.Size(198, 23);
            this.txtOsiguranik.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(84, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.Color.Snow;
            this.txtDatum.Location = new System.Drawing.Point(142, 135);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(198, 23);
            this.txtDatum.TabIndex = 17;
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.BackColor = System.Drawing.Color.Snow;
            this.lblPacijent.Location = new System.Drawing.Point(178, 76);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(55, 15);
            this.lblPacijent.TabIndex = 16;
            this.lblPacijent.Text = "Pacijent :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Puno ime i prezime pacijenta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ime pacijenta :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.BackColor = System.Drawing.Color.Snow;
            this.txtPacijent.Location = new System.Drawing.Point(97, 35);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(275, 23);
            this.txtPacijent.TabIndex = 23;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.Snow;
            this.btnPretraga.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPretraga.FlatAppearance.BorderSize = 0;
            this.btnPretraga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretraga.Location = new System.Drawing.Point(379, 35);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 24;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtOsiguranik);
            this.groupBox1.Controls.Add(this.btnPretraga);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPacijent);
            this.groupBox1.Controls.Add(this.lblPacijent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDatum);
            this.groupBox1.Controls.Add(this.cbVazece);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(87, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 191);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // frmOsiguranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ekarton.WinUI.Properties.Resources.Insurance_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOsiguranje";
            this.Size = new System.Drawing.Size(653, 412);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbVazece;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOsiguranik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
