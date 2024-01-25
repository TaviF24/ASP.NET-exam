using WebApp.Models.DTOs;

namespace WebApp.Services.Model1Service
{
	public interface IModel1Service
	{
		public Task<List<Model1DTO>> GetAllModels1();

		Model1DTO GetModel1ById(Guid id);

	}
}

