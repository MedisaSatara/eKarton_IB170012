using AutoMapper;
using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Mapping
{
    public class ekartonProfile:Profile
    {
        public ekartonProfile()
        {
            CreateMap<Databases.Korisnik, Model.Models.Korisnik>();
            CreateMap<Databases.Uloga, Model.Models.Uloga>();

            CreateMap<KorisnikSearchRequest, Databases.Korisnik>();
            CreateMap<KorisniciInsertRequest, Databases.Korisnik>();
            CreateMap<KorisniciUpdateRequest, Databases.Korisnik>();

            CreateMap<KorisnikUlogaInsertRequest, Databases.KorisnikUloga>();
            CreateMap<KorisnikUlogaSearchRequest, Databases.KorisnikUloga>();

            CreateMap<Databases.KorisnikUloga, Model.Models.KorisnikUloga>();

            CreateMap<Databases.Pacijent, Model.Models.Pacijent>();

            CreateMap<PacijentSearchRequest, Databases.Pacijent>();
            CreateMap<PacijentInsertRequest, Databases.Pacijent>();
            CreateMap<PacijentUpdateRequest, Databases.Pacijent>();

            CreateMap<Databases.Osiguranje, Model.Models.Osiguranje>();

            CreateMap<Databases.PacijentOsiguranje, Model.Models.PacijentOsiguranje>();

            CreateMap<PacijentOsiguranjeSearchRequest, Databases.PacijentOsiguranje>();
            CreateMap<PacijentOsiguranjeInsertRequest, Databases.PacijentOsiguranje>();

            CreateMap<Databases.Doktor, Model.Models.Doktor>();

            CreateMap<DoktorSearchRequest, Databases.Doktor>();
            CreateMap<DoktorInsertRequest, Databases.Doktor>();
            CreateMap<DoktorUpdateRequest, Databases.Doktor>();

            CreateMap<Databases.Odjel, Model.Models.Odjel>();

            CreateMap<OdjelSearchRequest, Databases.Odjel>();
            CreateMap<OdjelInsertRequest, Databases.Odjel>();
            CreateMap<OdjelUpdateRequest, Databases.Odjel>();

            CreateMap<Databases.PreventivneMjere, Model.Models.PreventivneMjere>();
            CreateMap<Databases.SistematskiPregled, Model.Models.SistematskiPregled>();

            CreateMap<PreventivneMjereSearchRequest, Databases.PreventivneMjere>();
            CreateMap<SistematskiPregledSearchRequest, Databases.SistematskiPregled>();

            CreateMap<NalazSearchRequest, Databases.Nalaz>();
            CreateMap<PregledSearchRequest, Databases.Pregled>();

            CreateMap<Databases.Nalaz, Model.Models.Nalaz>();
            CreateMap<Databases.Pregled, Model.Models.Pregled>();
            CreateMap<Databases.Terapija, Model.Models.Terapija>();
            CreateMap<Databases.Uputnica, Model.Models.Uputnica>();
            CreateMap<Databases.OcjenaDoktora, Model.Models.OcjenaDoktora>();




































            // CreateMap<Databases.Pacijent, Model.Models.Pacijent>();
        }
    }
}
