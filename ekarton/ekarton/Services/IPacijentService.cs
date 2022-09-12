using ekarton.Model.Models;
using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IPacijentService
    {
        List<Pacijent> Get(PacijentSearchRequest search);
        //Model.Models.Pacijent Authenticiraj(string username, string pass);
        //Task<Model.Models.Pacijent> Login(string username, string password);
        Pacijent GetById(int id);

        void Insert(PacijentInsertRequest request);

        void Update(int id, PacijentUpdateRequest request);
    }
}
