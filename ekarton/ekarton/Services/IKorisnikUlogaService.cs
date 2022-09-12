using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IKorisnikUlogaService
    {
        public List<Model.Models.KorisnikUloga> Get(KorisnikUlogaSearchRequest request=null);
        Task<Model.Models.KorisnikUloga> Insert(KorisnikUlogaInsertRequest request);
    }
}
