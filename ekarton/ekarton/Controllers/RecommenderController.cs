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
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommenderService _service;

        public RecommenderController(IRecommenderService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetSlicneDoktore/{doktorId}")]
        public List<Model.Models.Doktor> GetSlicneDoktore(int doktorId)
        {
            return _service.GetSlicneDoktore(doktorId);
        }
    }
}
