using System;
using System.Collections.Generic;

#nullable disable

namespace ekarton.Databases
{
    public partial class Vakcinacija
    {
        public Vakcinacija()
        {
            PacijentVakcinacijas = new HashSet<PacijentVakcinacija>();
        }

        public int VakcinacijaId { get; set; }
        public string NazivVakcine { get; set; }

        public virtual ICollection<PacijentVakcinacija> PacijentVakcinacijas { get; set; }
    }
}
