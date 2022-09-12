using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Nalaz
{
    public partial class frmNalaz : UserControl
    {
        ApiService _nalazService = new ApiService("Nalaz");
        public frmNalaz()
        {
            InitializeComponent();
            dgvNalaz.AutoGenerateColumns = false;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            NalazSearchRequest request = new NalazSearchRequest()
            {
                ImePacijenta = txtPacijent.Text
            };
            var item =await  _nalazService.Get<List<Model.Models.Nalaz>>(request);
            dgvNalaz.DataSource = item;
        }
    }
}
