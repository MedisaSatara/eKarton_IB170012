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
    public class DoktorController : ControllerBase
    {
        private readonly IDoktorService _service;
        public DoktorController(IDoktorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Doktor> Get([FromQuery] DoktorSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Doktor GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public void Insert(DoktorInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] DoktorUpdateRequest request)
        {
            _service.Update(id, request);
        }
        [AllowAnonymous]
        [HttpGet("{id}/recommend")]
        public List<Model.Models.Doktor>Recommend(int id)
        {
            return (_service as IDoktorService).Recommender(id);

        }
    }
}
