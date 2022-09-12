using AutoMapper;
using ekarton.Databases;
using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class SistematskiPregledService:ISistematskiPregledService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;

        public SistematskiPregledService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.SistematskiPregled> Get(SistematskiPregledSearchRequest request = null)
        {
            var query = Context.SistematskiPregleds.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePacijenta))
            {
                query = query.Where(x => x.Pacijent.Ime == request.ImePacijenta);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.SistematskiPregled>>(list);
            //return Context.Odjels.ToList().Select(x => _mapper.Map<Model.Odjel>(x)).ToList();

        }

        public Model.Models.SistematskiPregled GetById(int id)
        {
            var entity = Context.SistematskiPregleds.Find(id);

            return _mapper.Map<Model.Models.SistematskiPregled>(entity);
        }
    }
}
