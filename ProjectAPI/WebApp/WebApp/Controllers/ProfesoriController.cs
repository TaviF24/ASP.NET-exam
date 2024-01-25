using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;
using WebApp.Models.DTOs;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoriController : ControllerBase
    {
        private readonly WebAppContext _webAppContext;
        //public IMapper _mapper;

        public ProfesoriController(WebAppContext webAppContext)
        {
            _webAppContext = webAppContext;
            //_mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allProfesori = _webAppContext.Profesori;
            if (allProfesori == null)
                return BadRequest("Does not exist");
            return Ok(allProfesori);
            
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProfesoriDTO profesoriDTO)
        {
            var newModel1 = new Profesori();
            newModel1.Id = Guid.NewGuid();
            newModel1.FirstName = profesoriDTO.FirstName;
            newModel1.LastName = profesoriDTO.LastName;

            await _webAppContext.AddAsync(newModel1);
            await _webAppContext.SaveChangesAsync();
            return Ok(newModel1);
        }

    }
}
