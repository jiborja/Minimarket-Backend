using Ardalis.Specification.EntityFrameworkCore;
using Persistencia.Interfaces;
using Persistencia.Contexts;

namespace Persistencia.Repository
{
    public class MyRepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly InventarioDbContext _dbContext;
        public MyRepositoryAsync(InventarioDbContext dbContext) : base (dbContext)
        {
            _dbContext = dbContext;
        }
    }
}