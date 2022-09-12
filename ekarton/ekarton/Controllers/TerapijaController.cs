using ekarton.Model.Models;
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
    public class TerapijaController : ControllerBase
    {
        private readonly ITerapijaService _service;
        public TerapijaController(ITerapijaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Terapija> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public Terapija GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
