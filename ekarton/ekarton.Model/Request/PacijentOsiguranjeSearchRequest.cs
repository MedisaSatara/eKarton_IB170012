using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Request
{
    public class PacijentOsiguranjeSearchRequest
    {
        public string ImePacijenta { get; set; }
        public bool? IncludeOsiguranje { get; set; }
        public bool? IncludePacijent { get; set; }

    }
}
