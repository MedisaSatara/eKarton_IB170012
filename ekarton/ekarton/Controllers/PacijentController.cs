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
    public class PacijentController : ControllerBase
    {
        private readonly IPacijentService _service;

        public PacijentController(IPacijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Pacijent> Get([FromQuery] PacijentSearchRequest request)
        {
            return _service.Get(request);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public void Insert(PacijentInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] PacijentUpdateRequest request)
        {
            _service.Update(id, request);
        }
        [HttpGet("{id}")]
        public Pacijent GetById(int id)
        {
            return _service.GetById(id);
        }
        
    }
}
