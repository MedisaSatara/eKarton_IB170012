using ekarton.Model.Models;
using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public interface IKorisnikService
    {
        List<Model.Models.Korisnik> Get(KorisnikSearchRequest search);
        Korisnik GetById(int id);
        Model.Models.Korisnik Insert(KorisniciInsertRequest request);
        void Update(int id, KorisniciUpdateRequest request);
        Task<Model.Models.Korisnik> Login(string username, string password);
        Korisnik Authenticiraj(string username, string pass);


    }
}
