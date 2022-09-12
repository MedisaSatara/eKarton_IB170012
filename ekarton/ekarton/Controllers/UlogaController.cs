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
    public class UlogaController : ControllerBase
    {
        private readonly IUlogaService _service;
        public UlogaController(IUlogaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Uloga> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        [Route("ProvjeriAdmin/{UlogaId}")]
        public Uloga ProvjeriAdmin(int UlogaId)
        {
            return _service.ProvjeriAdmin(UlogaId);
        }
    }
}
