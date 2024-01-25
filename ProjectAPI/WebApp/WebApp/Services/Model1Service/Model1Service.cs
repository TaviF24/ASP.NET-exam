using AutoMapper;
using WebApp.Models.DTOs;
using WebApp.Repositories.Model1Repository;

namespace WebApp.Services.Model1Service
{
	public class Model1Service : IModel1Service
	{
        public IModel1Repository? _model1Repository;
        public IMapper _mapper;

        public Model1Service(IModel1Repository model1Repository, IMapper mapper)
        {
            _model1Repository = model1Repository;
            _mapper = mapper;
        }

        public async Task<List<Model1DTO>> GetAllModels1()
        {
            var model1List = await _model1Repository.GetAllAsync();
            return _mapper.Map<List<Model1DTO>>(model1List);
        }

        public Model1DTO GetModel1ById(Guid id)
        {
            var model1 = _model1Repository.FindById(id);

            /*
            var userDTO = new UserDTO()
            {
                Username = user.Username,
                Email = user.Email,
                FullName = user.FirstName + user.LastName
            };
            */
            // Sunt echivalente
            var model1DTO = _mapper.Map<Model1DTO>(model1);
            return model1DTO;
        }
    }
}

