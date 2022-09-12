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
    public class PacijentOsiguranjeController : ControllerBase
    {
        private readonly IPacijentOsiguranjeService _service;
        public PacijentOsiguranjeController(IPacijentOsiguranjeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.PacijentOsiguranje> Get([FromQuery] PacijentOsiguranjeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public async Task<Model.Models.PacijentOsiguranje> Insert([FromBody] PacijentOsiguranjeInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
