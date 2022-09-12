using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface ISistematskiPregledService
    {
        IEnumerable<Model.Models.SistematskiPregled> Get(SistematskiPregledSearchRequest request = null);
        Model.Models.SistematskiPregled GetById(int Id);
    }
}
