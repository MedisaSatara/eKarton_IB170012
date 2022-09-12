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
    public class PreventivneMjereController : ControllerBase
    {
        private readonly IPreventivneMjereService _service;

        public PreventivneMjereController(IPreventivneMjereService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.PreventivneMjere> Get([FromQuery] PreventivneMjereSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Models.PreventivneMjere GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
