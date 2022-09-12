
namespace ekarton.WinUI.Doktor
{
    partial class frmDodajUrediOdjel
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
            this.txtNazivOdjela = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(108, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv odjela :";
            // 
            // txtNazivOdjela
            // 
            this.txtNazivOdjela.BackColor = System.Drawing.Color.LightCoral;
            this.txtNazivOdjela.Location = new System.Drawing.Point(201, 44);
            this.txtNazivOdjela.Name = "txtNazivOdjela";
            this.txtNazivOdjela.Size = new System.Drawing.Size(140, 23);
            this.txtNazivOdjela.TabIndex = 1;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.BackColor = System.Drawing.Color.LightCoral;
            this.txtBrojTelefona.Location = new System.Drawing.Point(201, 82);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(140, 23);
            this.txtBrojTelefona.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(108, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj telefona :";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.Snow;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Location = new System.Drawing.Point(263, 112);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // frmDodajUrediOdjel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(453, 198);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazivOdjela);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajUrediOdjel";
            this.Text = "frmDodajUrediOdjel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivOdjela;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}