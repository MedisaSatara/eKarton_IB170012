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
    public class PacijentOsiguranjeService:IPacijentOsiguranjeService
    {
        private readonly rekartonContext Context;
        private readonly IMapper _mapper;

        public PacijentOsiguranjeService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Models.PacijentOsiguranje> Get(PacijentOsiguranjeSearchRequest request = null)
        {
            var query = Context.PacijentOsiguranjes.AsQueryable();
            if (request?.IncludeOsiguranje == true)
            {
                query = query.Include(x => x.Osiguranje);
            }
            if(request?.IncludePacijent==true)
            {
                query = query.Include(x => x.Pacijent);
            }
            if (!string.IsNullOrWhiteSpace(request?.ImePacijenta))
            {
                query = query.Where(x => x.Pacijent.Ime.Contains(request.ImePacijenta));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.PacijentOsiguranje>>(list);
        }
        public async Task<Model.Models.PacijentOsiguranje> Insert(PacijentOsiguranjeInsertRequest request)
        {
            Databases.PacijentOsiguranje entity = _mapper.Map<Databases.PacijentOsiguranje>(request);
            await Context.PacijentOsiguranjes.AddAsync(entity);
            await Context.SaveChangesAsync();
            return _mapper.Map<Model.Models.PacijentOsiguranje>(entity);
        }
    }
}
