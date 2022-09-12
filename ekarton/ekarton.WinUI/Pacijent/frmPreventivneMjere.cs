using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ekarton.WinUI.Pacijent
{
    public partial class frmPreventivneMjere : Form
    {
        private Model.Models.Pacijent pacijent;
        ApiService _preventivneMjereService = new ApiService("PreventivneMjere");
        ApiService _pacijentService = new ApiService("Pacijent");

        private Model.Models.PreventivneMjere mjera;


        public frmPreventivneMjere(Model.Models.PreventivneMjere mjera)
        {
            InitializeComponent();
            this.mjera = mjera;
        }

        private async void frmPreventivneMjere_Load(object sender, EventArgs e)
        {

           if(mjera!=null)
            {
                var listaMjera =await _preventivneMjereService.Get<List<Model.Models.PreventivneMjere>>(mjera);
                dgvPreventivneMjere.DataSource = listaMjera;
                var listaPacijenata = await _pacijentService.Get<List<Model.Models.Pacijent>>(null);
                foreach(var mjere in listaMjera)
                {
                    if(mjere.PacijentId!=0)
                    {
                        foreach(var pacijent in listaPacijenata)
                        {
                            if(mjere.PacijentId==pacijent.PacijentId)
                            {
                                lblPacijent.Text = pacijent.Ime;
                                txtStanje.Text = mjere.Stanje;
                            }
                        }
                    }
                }
            }
        }
    }
}
