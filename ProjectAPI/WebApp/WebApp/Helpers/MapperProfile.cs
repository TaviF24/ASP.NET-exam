using AutoMapper;
using WebApp.Models;
using WebApp.Models.DTOs;

namespace WebApp.Helpers  // ne ajuta sa nu mai stam noi sa atribuim fiecare data membra, ci sa o faca el
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<Materii, MateriiDTO>();
			CreateMap<Profesori, ProfesoriDTO>();
            CreateMap<ModelRelationDTO, ModelRelation>();
        }
	}
}

