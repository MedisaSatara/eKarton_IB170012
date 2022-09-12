using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Models
{
    public class Osiguranje
    {
        public Osiguranje()
        {
        }

        public int OsiguranjeId { get; set; }
        public string Osiguranik { get; set; }

        //public virtual ICollection<PacijentOsiguranje> PacijentOsiguranjes { get; set; }
    }
}
