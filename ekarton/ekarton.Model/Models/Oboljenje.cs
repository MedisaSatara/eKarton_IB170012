using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Models
{
    public class Oboljenje
    {

        public int OboljenjeId { get; set; }
        public string Dijagnoza { get; set; }
        public string Terapija { get; set; }

        //public virtual ICollection<PacijentOboljenje> PacijentOboljenjes { get; set; }
    }
}
