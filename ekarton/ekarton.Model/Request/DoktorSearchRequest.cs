using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Request
{
    public class DoktorSearchRequest
    {
        public string ImeDoktor { get; set; }
        public bool? IncludeOdjel { get; set; }
        public string NazivOdjela { get; set; }
    }
}
