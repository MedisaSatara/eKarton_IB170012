using AutoMapper;
using ekarton.Databases;
using ekarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class NalazService:INalazService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;

        public NalazService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Nalaz> Get(NalazSearchRequest request = null)
        {
            var query = Context.Nalazs.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePacijenta))
            {
                query = query.Where(x => x.Pacijent.Ime == request.ImePacijenta);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Nalaz>>(list);
            //return Context.Odjels.ToList().Select(x => _mapper.Map<Model.Odjel>(x)).ToList();

        }

        public Model.Models.Nalaz GetById(int id)
        {
            var entity = Context.Nalazs.Find(id);
            return _mapper.Map<Model.Models.Nalaz>(entity);
        }
    }
}
