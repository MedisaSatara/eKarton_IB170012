using ekarton.WinUI.Doktor;
using ekarton.WinUI.Korisnik;
using ekarton.WinUI.Pacijent;
using ekarton.WinUI.Pregled;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Login
{
    public partial class frmPocetnaKorisnik : Form
    {
        private int childFormNumber = 0;

        public frmPocetnaKorisnik()
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
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void pretragaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            frm.Show();
        }

        private void pretragaPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacijenti frm = new frmPacijenti();
            frm.Show();
        }

        private void prikazPregledaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregled frm = new frmPregled();
            frm.ShowDialog();
        }

        private void doktoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDostupnihDoktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktor frm = new frmDoktor();
            frm.Show();
        }

        private void odjeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdjel frm = new frmOdjel();
            frm.Show();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            var frm = new frmConfiramtionLogin();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                Close();
                //PrijavljeniKorisnikService.PrijavljeniKorisnik = null;
                var loginPonovo = new frmLogin();
                loginPonovo.ShowDialog();
            }
        }
    }
}
