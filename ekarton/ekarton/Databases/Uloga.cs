﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ekarton.Databases
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUlogas = new HashSet<KorisnikUloga>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string OpisUloge { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
    }
}
