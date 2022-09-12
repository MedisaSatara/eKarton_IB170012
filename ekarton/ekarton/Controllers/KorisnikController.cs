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

    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _service;
        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Korisnik> Get([FromQuery] KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public void Insert(KorisniciInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KorisniciUpdateRequest request)
        {
            _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Korisnik GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Korisnik Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }


    }
}
