using Microsoft.EntityFrameworkCore;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Config
{
    public abstract class IGenericRepository<T> : Interfaces.IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public IGenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(T obj)
        {
            await _applicationDbContext.Set<T>().AddAsync(obj);
        }

        public void Delete(T obj)
        {
            _applicationDbContext.Set<T>().Remove(obj);
        }

        public void Edit(T obj)
        {
            _applicationDbContext.Set<T>().Update(obj);
        }

        public virtual IQueryable<T> GetTracked()
        {
            return _applicationDbContext.Set<T>();
        }

        public virtual IQueryable<T> GetUntracked()
        {
            return _applicationDbContext.Set<T>().AsNoTracking();
        }
    }
}
