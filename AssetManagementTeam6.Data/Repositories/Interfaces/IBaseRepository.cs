﻿using AssetManagementTeam6.Data.Entities;
using System.Linq.Expressions;

namespace AssetManagementTeam6.Data.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity<int>
    {
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null);
        Task<T?> GetOneAsync(Expression<Func<T, bool>>? predicate = null);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
