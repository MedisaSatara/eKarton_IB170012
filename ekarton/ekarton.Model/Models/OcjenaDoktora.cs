using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Models
{
    public class OcjenaDoktora
    {
        public int OcjenaId { get; set; }
        public int Ocjena { get; set; }
        public string Razlog { get; set; }
        public bool? Anonimno { get; set; }
        public int DoktorId { get; set; }

        public virtual Doktor Doktor { get; set; }
    }
}
