
namespace ekarton.WinUI.Pacijent
{
    partial class frmPacijenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacijenti));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOsiguranje = new System.Windows.Forms.Button();
            this.btnNalazi = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.frmPretraga1 = new ekarton.WinUI.Pacijent.frmPretraga();
            this.frmNalaz1 = new ekarton.WinUI.Nalaz.frmNalaz();
            this.frmOsiguranje1 = new ekarton.WinUI.Pacijent.frmOsiguranje();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.btnOsiguranje);
            this.panel2.Controls.Add(this.btnNalazi);
            this.panel2.Controls.Add(this.btnPretraga);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnOsiguranje
            // 
            this.btnOsiguranje.BackColor = System.Drawing.Color.Snow;
            this.btnOsiguranje.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnOsiguranje.FlatAppearance.BorderSize = 0;
            this.btnOsiguranje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnOsiguranje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsiguranje.Location = new System.Drawing.Point(276, 27);
            this.btnOsiguranje.Name = "btnOsiguranje";
            this.btnOsiguranje.Size = new System.Drawing.Size(124, 23);
            this.btnOsiguranje.TabIndex = 19;
            this.btnOsiguranje.Text = "Osiguranje";
            this.btnOsiguranje.UseVisualStyleBackColor = false;
            this.btnOsiguranje.Click += new System.EventHandler(this.btnOsiguranje_Click);
            // 
            // btnNalazi
            // 
            this.btnNalazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNalazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnNalazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNalazi.Location = new System.Drawing.Point(138, 27);
            this.btnNalazi.Name = "btnNalazi";
            this.btnNalazi.Size = new System.Drawing.Size(132, 23);
            this.btnNalazi.TabIndex = 3;
            this.btnNalazi.Text = "Nalazi";
            this.btnNalazi.UseVisualStyleBackColor = false;
            this.btnNalazi.Click += new System.EventHandler(this.btnNalazi_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretraga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretraga.Location = new System.Drawing.Point(0, 27);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(132, 23);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraga pacijenata";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // frmPretraga1
            // 
            this.frmPretraga1.BackColor = System.Drawing.Color.Snow;
            this.frmPretraga1.Location = new System.Drawing.Point(69, 55);
            this.frmPretraga1.Name = "frmPretraga1";
            this.frmPretraga1.Size = new System.Drawing.Size(677, 370);
            this.frmPretraga1.TabIndex = 2;
            this.frmPretraga1.Load += new System.EventHandler(this.frmPretraga1_Load_1);
            // 
            // frmNalaz1
            // 
            this.frmNalaz1.BackColor = System.Drawing.Color.Snow;
            this.frmNalaz1.Location = new System.Drawing.Point(79, 64);
            this.frmNalaz1.Name = "frmNalaz1";
            this.frmNalaz1.Size = new System.Drawing.Size(648, 352);
            this.frmNalaz1.TabIndex = 3;
            // 
            // frmOsiguranje1
            // 
            this.frmOsiguranje1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmOsiguranje1.BackgroundImage")));
            this.frmOsiguranje1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmOsiguranje1.Location = new System.Drawing.Point(69, 55);
            this.frmOsiguranje1.Name = "frmOsiguranje1";
            this.frmOsiguranje1.Size = new System.Drawing.Size(677, 370);
            this.frmOsiguranje1.TabIndex = 4;
            // 
            // frmPacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmOsiguranje1);
            this.Controls.Add(this.frmNalaz1);
            this.Controls.Add(this.frmPretraga1);
            this.Controls.Add(this.panel2);
            this.Name = "frmPacijenti";
            this.Text = "frmPacijenti";
            this.Load += new System.EventHandler(this.frmPacijenti_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNalazi;
        private System.Windows.Forms.Button btnPretraga;
        private frmPretraga frmPretraga1;
        private System.Windows.Forms.Button btnOsiguranje;
        private Nalaz.frmNalaz frmNalaz1;
        private frmOsiguranje frmOsiguranje1;
    }
}