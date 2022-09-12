using System;
using System.Collections.Generic;
using System.Text;

namespace ekarton.Model.Request
{
    public class PreventivneMjereSearchRequest
    {
        public string ImePacijent { get; set; }
        public bool? IncludePacijent { get; set; }
    }
}
