using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Models
{
    public class PreventivneMjere
    {
        public int MjereId { get; set; }
        public string Stanje { get; set; }
        public int PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
    }
}
