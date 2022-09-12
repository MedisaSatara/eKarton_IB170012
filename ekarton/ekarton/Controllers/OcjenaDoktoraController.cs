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
    public class OcjenaDoktoraController : ControllerBase
    {

        private readonly IOcjenaDoktoraService _service;

        public OcjenaDoktoraController(IOcjenaDoktoraService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.OcjenaDoktora> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.Models.OcjenaDoktora GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
