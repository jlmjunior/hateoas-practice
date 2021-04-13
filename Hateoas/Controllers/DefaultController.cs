using Hateoas.Business;
using Hateoas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hateoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        private readonly ILogger<DefaultController> _logger;
        private readonly IPersonBusiness _personBusiness;

        public DefaultController(ILogger<DefaultController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_personBusiness.FindAll());
        }
    }
}
