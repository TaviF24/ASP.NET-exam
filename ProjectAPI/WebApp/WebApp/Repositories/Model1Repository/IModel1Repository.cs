using WebApp.Models;
using WebApp.Repositories.GenericRepository;

namespace WebApp.Repositories.Model1Repository
{
	public interface IModel1Repository : IGenericRepository<Model1>
	{
        Model1 FindById(Guid id);
    }
}

