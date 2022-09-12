using AutoMapper;
using ekarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class OsiguranjeService:IOsiguranjeService
    {
        private readonly rekartonContext _context;
        private readonly IMapper _mapper;

        public OsiguranjeService(rekartonContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Models.Osiguranje> Get()
        {
            List<Model.Models.Osiguranje> result = new List<Model.Models.Osiguranje>();
            var lista = _context.Osiguranjes.ToList();

            foreach (var item in lista)
            {
                Model.Models.Osiguranje uloga = new Model.Models.Osiguranje();
                uloga.Osiguranik = item.Osiguranik;
                uloga.OsiguranjeId = item.OsiguranjeId;

                result.Add(uloga);
            }
            return result;
        }

        
    }
}
