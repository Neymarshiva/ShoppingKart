using Core.Entities;
using Core.Specification;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecifiation<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecifiation<T> spec);
        Task<int> CountAsync(ISpecifiation<T> spec);
    }
}
