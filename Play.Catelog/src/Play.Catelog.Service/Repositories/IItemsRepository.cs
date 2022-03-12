using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Play.Catelog.Service.Entities;

namespace Play.Catelog.Service.Repositories
{
    public interface IItemsRepository
    {
        Task CreateAsync(Item entity);
        Task DeleteAsync(Guid id);
        Task<IReadOnlyCollection<Item>> GetAllAsync();
        Task<Item> GetAsync(Guid id);
        Task UpdateAsync(Item entity);
    }

}