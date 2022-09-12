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
    public class UputnicaController : ControllerBase
    {
        private readonly IUputnicaService _service;
        public UputnicaController(IUputnicaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Uputnica> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public Uputnica GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
