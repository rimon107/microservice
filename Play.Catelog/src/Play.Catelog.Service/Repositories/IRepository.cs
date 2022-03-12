using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Play.Catelog.Service.Entities;

namespace Play.Catelog.Service.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task UpdateAsync(T entity);
    }

}