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
    public class KorisnikUlogaService:IKorisnikUlogaService
    {
        private readonly rekartonContext Context;
        private readonly IMapper _mapper;

        public KorisnikUlogaService(rekartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Models.KorisnikUloga> Get(KorisnikUlogaSearchRequest request=null)
        {
            var query = Context.KorisnikUlogas.AsQueryable();
            if(request?.IncludeUloga==true)
            {
                query = query.Include(x => x.Uloga);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.KorisnikUloga>>(list);
        }
        public async Task<Model.Models.KorisnikUloga> Insert(KorisnikUlogaInsertRequest request)
        {
            Databases.KorisnikUloga entity = _mapper.Map<Databases.KorisnikUloga>(request);
            await Context.KorisnikUlogas.AddAsync(entity);
            await Context.SaveChangesAsync();
            return _mapper.Map<Model.Models.KorisnikUloga>(entity);
        }
    }
}
