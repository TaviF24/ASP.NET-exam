using WebApp.Data;
using WebApp.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Repositories.GenericRepository
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
	{
		protected readonly WebAppContext? _webAppContext;
        protected readonly DbSet<TEntity>? _table;

		public GenericRepository(WebAppContext webAppContext)
		{
			_webAppContext = webAppContext;
			_table = _webAppContext.Set<TEntity>();	// in loc sa scriu mereu  _lab4Context.NumeleTabelului.CevreauSaFac
		}


        //	Get all
        public List<TEntity> GetAll()
        {
            return _table.AsNoTracking().ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
		{
			return await _table.AsNoTracking().ToListAsync();
		}




		//	Create
		public void Create(TEntity entity)
		{
			_table.Add(entity);
		}

		public async Task CreateAsync(TEntity entity)
		{
			await _table.AddAsync(entity);
		}

        public void CreateRange(IEnumerable<TEntity> entities)
		{
			_table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
		{
			await _table.AddRangeAsync(entities);
		}



        //	Update
        public void Update(TEntity entity)
		{
			_table.Update(entity);
		}

        public void UpdateRange(IEnumerable<TEntity> entities)
		{
			_table.UpdateRange(entities);
		}



        //	Delete
        public void Delete(TEntity entity)
		{
			_table.Remove(entity);
		}

        public void DeleteRange(IEnumerable<TEntity> entities)
		{
			_table.RemoveRange(entities);
		}



        //	Find
        public TEntity FindById(Guid id)
		{
			return _table.Find(id);		//mergea si _table.FirstOrDefault
        }

        public async Task<TEntity> FindByIdAsync(Guid id)
		{
			return await _table.FindAsync(id);
		}



        //	Save
        public bool Save()
		{
			return _webAppContext.SaveChanges() > 0;
		}

        public async Task<bool> SaveAsync(TEntity entity)
		{
			return await _webAppContext.SaveChangesAsync() > 0;
		}
    }
}

