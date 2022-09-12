using ekarton.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IOsiguranjeService
    {
        List<Osiguranje> Get();
    }
}
