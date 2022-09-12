using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Databases
{
    public partial class DodjeljenDoktor
    {
        public int DodjeljenDoktorId { get; set; }

        public int PacijentId { get; set; }
        public int DoktorId { get; set; }
        public DateTime? DatumOd { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
