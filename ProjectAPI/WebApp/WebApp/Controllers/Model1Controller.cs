using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services.Model1Service;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Model1Controller : ControllerBase
    {
        private IModel1Service? _model1Service;

        public Model1Controller(IModel1Service model1Service)
        {
            _model1Service = model1Service;
        }

        [HttpGet]
        public IActionResult GetModel1ById(Guid id)
        {
            var model1 = _model1Service.GetModel1ById(id);
            if (model1 == null)
                return BadRequest("Object does not exist");
            return Ok(model1);
        }
    }
}
