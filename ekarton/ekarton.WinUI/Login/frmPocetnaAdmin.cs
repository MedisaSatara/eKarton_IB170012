using ekarton.WinUI.Doktor;
using ekarton.WinUI.Korisnik;
using ekarton.WinUI.Pacijent;
using ekarton.WinUI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Login
{
    public partial class frmPocetnaAdmin : Form
    {
        private int childFormNumber = 0;

        public frmPocetnaAdmin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void listaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            frm.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika frm = new frmDodajKorisnika();
            frm.Show();
        }

        private void listaPacijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPacijent frm = new frmPacijent();
            //frm.Show();
            frmPacijenti frm = new frmPacijenti();
            frm.Show();
        }

        private void listaDostupnihDoktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktor frm = new frmDoktor();
            frm.Show();

        }

        private void dodajDoktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajUrediDoktora frm = new frmDodajUrediDoktora();
            frm.Show();

        }

        private void odjeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdjel frm = new frmOdjel();
            frm.Show();

        }

        private void dodajOdjelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajUrediOdjel frm = new frmDodajUrediOdjel();
            frm.Show();
        }

        private void frmPocetnaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void izvjestajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktoriPoOcjenama frm = new frmDoktoriPoOcjenama();
            frm.Show();
        }
    }
}
