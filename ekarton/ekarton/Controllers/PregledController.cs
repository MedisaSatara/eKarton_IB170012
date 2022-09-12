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
    public class PregledController : ControllerBase
    {
        private readonly IPregledService _service;

        public PregledController(IPregledService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.Pregled> Get([FromQuery] PregledSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Models.Pregled GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
