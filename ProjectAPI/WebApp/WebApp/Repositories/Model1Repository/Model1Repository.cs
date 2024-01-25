using WebApp.Data;
using WebApp.Models;
using WebApp.Repositories.GenericRepository;

namespace WebApp.Repositories.Model1Repository
{
	public class Model1Repository : GenericRepository<Model1>, IModel1Repository
	{
		public Model1Repository(WebAppContext webAppContext) : base(webAppContext) { }

        public Model1 FindById(Guid id)
        {
            return _table.FirstOrDefault(u => u.Id == id);
        }

    }
}

