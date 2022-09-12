using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Pacijent
{
    public partial class frmPacijenti : Form
    {
        public frmPacijenti()
        {
            InitializeComponent();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            frmPretraga1.Visible = true;
            frmNalaz1.Visible = false;
            frmOsiguranje1.Visible = false;
        }

        private void frmPretraga1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNalazi_Click(object sender, EventArgs e)
        {
           frmNalaz1.Visible = true;
            frmPretraga1.Visible = false;
            frmOsiguranje1.Visible = false;
        }

        private void frmPretraga1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOsiguranje_Click(object sender, EventArgs e)
        {
           frmOsiguranje1.Visible = true;
            frmNalaz1.Visible = false;
            frmPretraga1.Visible = false;
        }

        private void frmPacijenti_Load(object sender, EventArgs e)
        {
            frmOsiguranje1.Visible = false;
            frmPretraga1.Visible = false;
            frmOsiguranje1.Visible = false;
        }
    }
}
