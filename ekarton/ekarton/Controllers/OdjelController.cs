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
    public class OdjelController : ControllerBase
    {
        private readonly IOdjelService _service;

        public OdjelController(IOdjelService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.Odjel> Get([FromQuery] OdjelSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Models.Odjel GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public Model.Models.Odjel Insert(OdjelInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public Model.Models.Odjel Update(int id, [FromBody] OdjelUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
