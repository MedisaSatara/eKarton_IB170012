using ekarton.Model.Models;
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
    public class NalazController : ControllerBase
    {
        private readonly INalazService _service;
        public NalazController(INalazService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Nalaz> Get([FromQuery] NalazSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Nalaz GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
