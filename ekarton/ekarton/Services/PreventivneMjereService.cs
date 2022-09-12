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
    public class PreventivneMjereService:IPreventivneMjereService
    {
        private readonly IMapper _mapper;
        private readonly rekartonContext Context;

        public PreventivneMjereService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.PreventivneMjere> Get(PreventivneMjereSearchRequest request=null)
        {
            var query = Context.PreventivneMjeres.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePacijent))
            {
                query = query.Where(x => x.Pacijent.Ime == request.ImePacijent);
            }
            if(request?.IncludePacijent==true)
            {
                query = query.Include(x => x.Pacijent);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.PreventivneMjere>>(list);
            //return Context.Odjels.ToList().Select(x => _mapper.Map<Model.Odjel>(x)).ToList();

        }

        public Model.Models.PreventivneMjere GetById(int id)
        {
            var entity = Context.PreventivneMjeres.Find(id);

            return _mapper.Map<Model.Models.PreventivneMjere>(entity);
        }
      
    }
}
