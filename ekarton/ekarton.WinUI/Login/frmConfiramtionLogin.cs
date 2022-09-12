using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Login
{
    public partial class frmConfiramtionLogin : Form
    {
        public frmConfiramtionLogin()
        {
            InitializeComponent();
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pozdrav!");
            DialogResult = DialogResult.Yes;
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
