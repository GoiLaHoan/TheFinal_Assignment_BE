using AssetManagementTeam6.Data.Entities;
using AssetManagementTeam6.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading;

namespace AssetManagementTeam6.Data.Repositories.Implements
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity<int>
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly AssetManagementContext _context;
        public BaseRepository(AssetManagementContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);

            return entity;
        }

        public Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);

            return Task.FromResult(true);
        }

        public async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null)
        {
            var dbSet = predicate == null ? _dbSet : _dbSet.Where(predicate);

            return await dbSet.ToListAsync();
        }

        public async Task<T?> GetOneAsync(Expression<Func<T, bool>>? predicate = null)
        {
            var dbSet = predicate == null ? _dbSet.FirstOrDefaultAsync() : _dbSet.FirstOrDefaultAsync(predicate);

            return await dbSet;
        }

        public Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);

            return Task.FromResult(entity);
        }
    }
}
