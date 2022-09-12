using AutoMapper;
using ekarton.Databases;
using ekarton.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Services
{
    public class PregledService:IPregledService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;

        public PregledService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Pregled> Get(PregledSearchRequest request = null)
        {
            var query = Context.Pregleds.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePacijenta))
            {
                query = query.Where(x => x.Pacijent.Ime == request.ImePacijenta);
            }
            if(request.IncludePacijent==true)
            {
                query = query.Include(x => x.Pacijent);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Pregled>>(list);
            //return Context.Odjels.ToList().Select(x => _mapper.Map<Model.Odjel>(x)).ToList();
        }

        public Model.Models.Pregled GetById(int id)
        {
            var entity = Context.Pregleds.Find(id);
            return _mapper.Map<Model.Models.Pregled>(entity);
        }
    }
}
