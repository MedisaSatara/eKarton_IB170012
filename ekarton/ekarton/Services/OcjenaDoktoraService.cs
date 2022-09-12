using AutoMapper;
using ekarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class OcjenaDoktoraService:IOcjenaDoktoraService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;

        public OcjenaDoktoraService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.OcjenaDoktora> Get()
        {
            var query = Context.OcjenaDoktoras.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.OcjenaDoktora>>(list);
            //return Context.Odjels.ToList().Select(x => _mapper.Map<Model.Odjel>(x)).ToList();

        }

        public Model.Models.OcjenaDoktora GetById(int id)
        {
            var entity = Context.OcjenaDoktoras.Find(id);

            return _mapper.Map<Model.Models.OcjenaDoktora>(entity);
        }
    }
}
