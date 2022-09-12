using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Request
{
    public class PregledSearchRequest
    {
        public string ImePacijenta { get; set; }
        public bool? IncludePacijent { get; set; }
    }
}
