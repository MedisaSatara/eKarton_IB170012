using AutoMapper;
using ekarton.Databases;
using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class UputnicaService:IUputnicaService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;

        public UputnicaService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.Models.Uputnica> Get()
        {
            var query = Context.Uputnicas.AsQueryable();
            
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Uputnica>>(list);
        }
        public Model.Models.Uputnica GetById(int id)
        {
            var entity = Context.Uputnicas.Find(id);
            return _mapper.Map<Model.Models.Uputnica>(entity);
        }
    }
}
