using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Request
{
    public class PacijentSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool? IncludeKorisnik { get; set; }
    }
}
