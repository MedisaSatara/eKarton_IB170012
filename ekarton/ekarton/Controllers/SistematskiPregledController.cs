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
    public class SistematskiPregledController : ControllerBase
    {
        private readonly ISistematskiPregledService _service;

        public SistematskiPregledController(ISistematskiPregledService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.SistematskiPregled> Get([FromQuery] SistematskiPregledSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Models.SistematskiPregled GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
