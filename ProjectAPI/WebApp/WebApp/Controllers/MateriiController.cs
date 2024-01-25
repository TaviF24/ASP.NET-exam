using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;
using WebApp.Models.DTOs;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriiController : ControllerBase
    {
        private readonly WebAppContext _webAppContext;
        //public IMapper _mapper;

        public MateriiController(WebAppContext webAppContext)
        {
            _webAppContext = webAppContext;
            //_mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allMaterii = _webAppContext.Materii;
            if (allMaterii == null)
                return BadRequest("Does not exist");
            return Ok(allMaterii);
            //return Ok(_mapper.Map<List<MateriiDTO>>(allMaterii));
        }

        [HttpPost]

        public async Task<IActionResult> Create(MateriiDTO materiiDTO)
        {
            var newModel1 = new Materii();
            newModel1.Id = Guid.NewGuid();
            newModel1.Name = materiiDTO.Name;

            await _webAppContext.AddAsync(newModel1);
            await _webAppContext.SaveChangesAsync();
            return Ok(newModel1);
        } 



    }
}
