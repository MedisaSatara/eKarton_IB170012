using AutoMapper;
using ekarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class UlogaService:IUlogaService
    {
        private readonly rekartonContext _context;
        private readonly IMapper _mapper;

        public UlogaService(rekartonContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Models.Uloga> Get()
        {
            List<Model.Models.Uloga> result = new List<Model.Models.Uloga>();
            var lista = _context.Ulogas.ToList();

            foreach (var item in lista)
            {
                Model.Models.Uloga uloga = new Model.Models.Uloga();
                uloga.Naziv = item.Naziv;
                uloga.OpisUloge = item.OpisUloge;
                uloga.UlogaId = item.UlogaId;

                result.Add(uloga);
            }
            return result;
        }

        public Model.Models.Uloga ProvjeriAdmin(int UlogaId)
        {
            var lista = _context.Ulogas.ToList();
            Model.Models.Uloga result = new Model.Models.Uloga();

            foreach (var item in lista)
            {
                if (item.UlogaId == UlogaId)
                {
                    if (item.Naziv.Contains("Admin"))
                    {
                        result.Naziv = item.Naziv;
                        result.OpisUloge = item.OpisUloge;
                        result.UlogaId = item.UlogaId;

                        return result;
                    }
                }
            }
            return null;
        }
    }
}
