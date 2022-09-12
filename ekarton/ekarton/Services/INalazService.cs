using ekarton.Model.Models;
using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface INalazService
    {
        IEnumerable<Nalaz> Get(NalazSearchRequest request = null);
        Nalaz GetById(int id);
    }
}
