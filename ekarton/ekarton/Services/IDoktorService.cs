using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IDoktorService
    {
        IEnumerable<Model.Models.Doktor> Get(DoktorSearchRequest search = null);
        Model.Models.Doktor GetById(int id);
        void Insert(DoktorInsertRequest request);
        void Update(int id, DoktorUpdateRequest request);
        List<Model.Models.Doktor> Recommender(int id);
    }
}
