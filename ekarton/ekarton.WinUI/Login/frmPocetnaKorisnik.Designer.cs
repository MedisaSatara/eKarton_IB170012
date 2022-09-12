
namespace ekarton.WinUI.Login
{
    partial class frmPocetnaKorisnik
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodjeljeniDoktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDostupnihDoktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazPregledaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.btnTehnickaPodrska = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.pacijentToolStripMenuItem,
            this.doktoriToolStripMenuItem,
            this.preglediToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(737, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaKorisnikaToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // pretragaKorisnikaToolStripMenuItem
            // 
            this.pretragaKorisnikaToolStripMenuItem.Name = "pretragaKorisnikaToolStripMenuItem";
            this.pretragaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pretragaKorisnikaToolStripMenuItem.Text = "Pretraga korisnika";
            this.pretragaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKorisnikaToolStripMenuItem_Click);
            // 
            // pacijentToolStripMenuItem
            // 
            this.pacijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaPacijentaToolStripMenuItem,
            this.dodjeljeniDoktorToolStripMenuItem});
            this.pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            this.pacijentToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacijentToolStripMenuItem.Text = "Pacijent";
            // 
            // pretragaPacijentaToolStripMenuItem
            // 
            this.pretragaPacijentaToolStripMenuItem.Name = "pretragaPacijentaToolStripMenuItem";
            this.pretragaPacijentaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pretragaPacijentaToolStripMenuItem.Text = "Pretraga pacijenta";
            this.pretragaPacijentaToolStripMenuItem.Click += new System.EventHandler(this.pretragaPacijentaToolStripMenuItem_Click);
            // 
            // dodjeljeniDoktorToolStripMenuItem
            // 
            this.dodjeljeniDoktorToolStripMenuItem.Name = "dodjeljeniDoktorToolStripMenuItem";
            this.dodjeljeniDoktorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dodjeljeniDoktorToolStripMenuItem.Text = "Dodjeljeni doktor";
            // 
            // doktoriToolStripMenuItem
            // 
            this.doktoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDostupnihDoktoraToolStripMenuItem,
            this.odjeliToolStripMenuItem});
            this.doktoriToolStripMenuItem.Name = "doktoriToolStripMenuItem";
            this.doktoriToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.doktoriToolStripMenuItem.Text = "Doktori";
            this.doktoriToolStripMenuItem.Click += new System.EventHandler(this.doktoriToolStripMenuItem_Click);
            // 
            // listaDostupnihDoktoraToolStripMenuItem
            // 
            this.listaDostupnihDoktoraToolStripMenuItem.Name = "listaDostupnihDoktoraToolStripMenuItem";
            this.listaDostupnihDoktoraToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.listaDostupnihDoktoraToolStripMenuItem.Text = "Lista dostupnih doktora";
            this.listaDostupnihDoktoraToolStripMenuItem.Click += new System.EventHandler(this.listaDostupnihDoktoraToolStripMenuItem_Click);
            // 
            // odjeliToolStripMenuItem
            // 
            this.odjeliToolStripMenuItem.Name = "odjeliToolStripMenuItem";
            this.odjeliToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.odjeliToolStripMenuItem.Text = "Odjeli";
            this.odjeliToolStripMenuItem.Click += new System.EventHandler(this.odjeliToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazPregledaToolStripMenuItem});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // prikazPregledaToolStripMenuItem
            // 
            this.prikazPregledaToolStripMenuItem.Name = "prikazPregledaToolStripMenuItem";
            this.prikazPregledaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.prikazPregledaToolStripMenuItem.Text = "Prikaz pregleda";
            this.prikazPregledaToolStripMenuItem.Click += new System.EventHandler(this.prikazPregledaToolStripMenuItem_Click);
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdjaviSe.FlatAppearance.BorderSize = 0;
            this.btnOdjaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjaviSe.Location = new System.Drawing.Point(653, 0);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(84, 24);
            this.btnOdjaviSe.TabIndex = 4;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // btnTehnickaPodrska
            // 
            this.btnTehnickaPodrska.Location = new System.Drawing.Point(618, 500);
            this.btnTehnickaPodrska.Name = "btnTehnickaPodrska";
            this.btnTehnickaPodrska.Size = new System.Drawing.Size(119, 23);
            this.btnTehnickaPodrska.TabIndex = 5;
            this.btnTehnickaPodrska.Text = "Tehnicka podrska";
            this.btnTehnickaPodrska.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ekarton.WinUI.Properties.Resources.d336e801_resize_820x0x100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 499);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dobro dosao, Korisnik !";
            // 
            // frmPocetnaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ekarton.WinUI.Properties.Resources.d336e801_resize_820x0x1002;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTehnickaPodrska);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPocetnaKorisnik";
            this.Text = "frmPocetnaKorisnik";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaPacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDostupnihDoktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodjeljeniDoktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazPregledaToolStripMenuItem;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Button btnTehnickaPodrska;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}



