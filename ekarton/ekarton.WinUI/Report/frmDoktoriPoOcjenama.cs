using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekarton.WinUI.Report
{
    public partial class frmDoktoriPoOcjenama : Form
    {
        ApiService _ocjeneDoktoraService = new ApiService("OcjenaDoktora");
        ApiService _doktorService = new ApiService("Doktor");

        public frmDoktoriPoOcjenama()
        {
            InitializeComponent();
            dgvOcjene.AutoGenerateColumns = false;
        }
        private async Task LoadDoktor(int doktorId = 0)
        {
                var result = await _doktorService.Get<List<Model.Models.Doktor>>();
                result.Insert(0, new Model.Models.Doktor());
                cmbDoktor.DisplayMember = "Ime";
                cmbDoktor.ValueMember = "DoktorId";
                cmbDoktor.DataSource = result;
        }
        private void frmDoktoriPoOcjenama_Load(object sender, EventArgs e)
        {

        }
        int doktorId = 0;
        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (doktorId != 0)
            {
                OcjeneDoktorSearchRequest request = new OcjeneDoktorSearchRequest();
                request.DoktorId = doktorId;
                var result = await _ocjeneDoktoraService.Get<List<Model.Models.OcjenaDoktora>>(request);
                dgvOcjene.DataSource = result;
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbDoktor.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                doktorId = id;
            }
        }
        Bitmap bitmap;

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            int height = dgvOcjene.Height;
            dgvOcjene.Height = dgvOcjene.RowCount * dgvOcjene.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvOcjene.Width, dgvOcjene.Height);
            dgvOcjene.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvOcjene.Width, dgvOcjene.Height));
            dgvOcjene.Height = height;


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private async Task LoadPodatke()
        {
            var result = await _ocjeneDoktoraService.Get<List<Model.Models.OcjenaDoktora>>();
            dgvOcjene.DataSource = result;
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

    }
}
