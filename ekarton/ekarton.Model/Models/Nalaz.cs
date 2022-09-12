using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Models
{
    public class Nalaz
    {
        public int NalazId { get; set; }
        public string Datum { get; set; }
        public string LicnaAnamneza { get; set; }
        public string RadnaAnamneza { get; set; }
        public string PorodicnaAnamneza { get; set; }
        public int PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
    }
}
