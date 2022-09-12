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
    public class OsiguranjeController : ControllerBase
    {
        private readonly IOsiguranjeService _service;
        public OsiguranjeController(IOsiguranjeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Osiguranje> Get()
        {
            return _service.Get();
        }
    }
}
