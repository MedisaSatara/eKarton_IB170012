
namespace ekarton.WinUI.Login
{
    partial class frmPocetnaAdmin
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
            this.listaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPacijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledOsiguranjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOsiguranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDostupnihDoktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDoktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOdjelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izvjestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.izvjestajToolStripMenuItem});
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
            this.listaKorisnikaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // listaKorisnikaToolStripMenuItem
            // 
            this.listaKorisnikaToolStripMenuItem.Name = "listaKorisnikaToolStripMenuItem";
            this.listaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listaKorisnikaToolStripMenuItem.Text = "Lista korisnika";
            this.listaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.listaKorisnikaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // pacijentToolStripMenuItem
            // 
            this.pacijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPacijenataToolStripMenuItem,
            this.pregledOsiguranjaToolStripMenuItem,
            this.dodajOsiguranjeToolStripMenuItem});
            this.pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            this.pacijentToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacijentToolStripMenuItem.Text = "Pacijent";
            // 
            // listaPacijenataToolStripMenuItem
            // 
            this.listaPacijenataToolStripMenuItem.Name = "listaPacijenataToolStripMenuItem";
            this.listaPacijenataToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaPacijenataToolStripMenuItem.Text = "Lista pacijenata";
            this.listaPacijenataToolStripMenuItem.Click += new System.EventHandler(this.listaPacijenataToolStripMenuItem_Click);
            // 
            // pregledOsiguranjaToolStripMenuItem
            // 
            this.pregledOsiguranjaToolStripMenuItem.Name = "pregledOsiguranjaToolStripMenuItem";
            this.pregledOsiguranjaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pregledOsiguranjaToolStripMenuItem.Text = "Pregled osiguranja";
            // 
            // dodajOsiguranjeToolStripMenuItem
            // 
            this.dodajOsiguranjeToolStripMenuItem.Name = "dodajOsiguranjeToolStripMenuItem";
            this.dodajOsiguranjeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.dodajOsiguranjeToolStripMenuItem.Text = "Dodaj osiguranje";
            // 
            // doktoriToolStripMenuItem
            // 
            this.doktoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDostupnihDoktoraToolStripMenuItem,
            this.dodajDoktoraToolStripMenuItem,
            this.odjeliToolStripMenuItem,
            this.dodajOdjelToolStripMenuItem});
            this.doktoriToolStripMenuItem.Name = "doktoriToolStripMenuItem";
            this.doktoriToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.doktoriToolStripMenuItem.Text = "Doktori";
            // 
            // listaDostupnihDoktoraToolStripMenuItem
            // 
            this.listaDostupnihDoktoraToolStripMenuItem.Name = "listaDostupnihDoktoraToolStripMenuItem";
            this.listaDostupnihDoktoraToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.listaDostupnihDoktoraToolStripMenuItem.Text = "Lista dostupnih doktora";
            this.listaDostupnihDoktoraToolStripMenuItem.Click += new System.EventHandler(this.listaDostupnihDoktoraToolStripMenuItem_Click);
            // 
            // dodajDoktoraToolStripMenuItem
            // 
            this.dodajDoktoraToolStripMenuItem.Name = "dodajDoktoraToolStripMenuItem";
            this.dodajDoktoraToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dodajDoktoraToolStripMenuItem.Text = "Dodaj doktora";
            this.dodajDoktoraToolStripMenuItem.Click += new System.EventHandler(this.dodajDoktoraToolStripMenuItem_Click);
            // 
            // odjeliToolStripMenuItem
            // 
            this.odjeliToolStripMenuItem.Name = "odjeliToolStripMenuItem";
            this.odjeliToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.odjeliToolStripMenuItem.Text = "Odjeli";
            this.odjeliToolStripMenuItem.Click += new System.EventHandler(this.odjeliToolStripMenuItem_Click);
            // 
            // dodajOdjelToolStripMenuItem
            // 
            this.dodajOdjelToolStripMenuItem.Name = "dodajOdjelToolStripMenuItem";
            this.dodajOdjelToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dodajOdjelToolStripMenuItem.Text = "Dodaj odjel";
            this.dodajOdjelToolStripMenuItem.Click += new System.EventHandler(this.dodajOdjelToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ekarton.WinUI.Properties.Resources.d336e801_resize_820x0x100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 499);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dobro dosao, Administrator !";
            // 
            // izvjestajToolStripMenuItem
            // 
            this.izvjestajToolStripMenuItem.Name = "izvjestajToolStripMenuItem";
            this.izvjestajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvjestajToolStripMenuItem.Text = "Izvjestaj";
            this.izvjestajToolStripMenuItem.Click += new System.EventHandler(this.izvjestajToolStripMenuItem_Click);
            // 
            // frmPocetnaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ekarton.WinUI.Properties.Resources.DR;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPocetnaAdmin";
            this.Text = "frmPocetnaAdmin";
            this.Load += new System.EventHandler(this.frmPocetnaAdmin_Load);
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
        private System.Windows.Forms.ToolStripMenuItem listaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPacijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledOsiguranjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOsiguranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDostupnihDoktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajDoktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOdjelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem izvjestajToolStripMenuItem;
    }
}



