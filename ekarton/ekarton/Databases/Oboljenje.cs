﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ekarton.Databases
{
    public partial class Oboljenje
    {
        public Oboljenje()
        {
            PacijentOboljenjes = new HashSet<PacijentOboljenje>();
        }

        public int OboljenjeId { get; set; }
        public string Dijagnoza { get; set; }
        public string Terapija { get; set; }

        public virtual ICollection<PacijentOboljenje> PacijentOboljenjes { get; set; }
    }
}
