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
    public class AllController : ControllerBase
    {
        private readonly WebAppContext _webAppContext;
        private IMapper _mapper;

        public AllController(WebAppContext webAppContext, IMapper mapper)
        {
            _webAppContext = webAppContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allData = _webAppContext.ModelRelations;
            if (allData == null)
                return BadRequest("Does not exist");
            return Ok(allData);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ModelRelationDTO modelRelationDTO)
        {
            var materie = _webAppContext.Materii.FirstOrDefault(x => x.Id == modelRelationDTO.MateriiId);
            var profesor = _webAppContext.Profesori.FirstOrDefault(x => x.Id == modelRelationDTO.ProfesoriId);

            if (materie == null || profesor == null)
                return BadRequest("Object does not exist");

            var newModel1 = new ModelRelation();
            newModel1.MateriiId = modelRelationDTO.MateriiId;
            newModel1.ProfesoriId = modelRelationDTO.ProfesoriId;
            newModel1.Materii = _webAppContext.Materii.FirstOrDefault(x => x.Id == modelRelationDTO.MateriiId);
            newModel1.Profesori = _webAppContext.Profesori.FirstOrDefault(x => x.Id == modelRelationDTO.ProfesoriId);
            await _webAppContext.AddAsync(newModel1);
            
            return Ok(await _webAppContext.SaveChangesAsync());
        }


    }
}
