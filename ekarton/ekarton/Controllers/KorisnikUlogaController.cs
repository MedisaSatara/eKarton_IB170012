using ekarton.Model.Request;
using ekarton.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class KorisnikUlogaController : ControllerBase
    {
        private readonly IKorisnikUlogaService _service;
        public KorisnikUlogaController(IKorisnikUlogaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.KorisnikUloga> Get([FromQuery]KorisnikUlogaSearchRequest request)
        {
            return _service.Get(request);
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public async Task<Model.Models.KorisnikUloga> Insert([FromBody] KorisnikUlogaInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
