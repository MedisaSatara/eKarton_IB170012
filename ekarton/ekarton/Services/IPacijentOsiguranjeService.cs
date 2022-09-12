using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IPacijentOsiguranjeService
    {
        public List<Model.Models.PacijentOsiguranje> Get(PacijentOsiguranjeSearchRequest request = null);
        Task<Model.Models.PacijentOsiguranje> Insert(PacijentOsiguranjeInsertRequest request);
    }
}
