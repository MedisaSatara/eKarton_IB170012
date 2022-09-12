using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Request
{
    public class KorisnikUlogaInsertRequest
    {
        public int PacijentOsiguranjeId { get; set; }
        public int OsiguranjeId { get; set; }
        public int PacijentId { get; set; }
        public DateTime DatumOsiguranja { get; set; }
        public bool Vazece { get; set; }
    }
}
