using AutoMapper;
using ekarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class TerapijaService:ITerapijaService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;

        public TerapijaService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.Models.Terapija> Get()
        {
            var query = Context.Terapijas.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Terapija>>(list);
        }
        public Model.Models.Terapija GetById(int id)
        {
            var entity = Context.Terapijas.Find(id);
            return _mapper.Map<Model.Models.Terapija>(entity);
        }
    }
}
