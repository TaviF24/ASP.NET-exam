using AutoMapper;
using WebApp.Models;
using WebApp.Models.DTOs;

namespace WebApp.Helpers  // ne ajuta sa nu mai stam noi sa atribuim fiecare data membra, ci sa o faca el
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<Model1, Model1DTO>();
			CreateMap<Model1DTO, Model1>();

			CreateMap<Model1, Model1DTO>()	
					.ForMember(model1dto => model1dto.FullName,
					opts => opts.MapFrom(model1 => model1.FirstName + model1.LastName));
        }
	}
}

