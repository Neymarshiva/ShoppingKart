using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using EmplyoeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Api.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }       

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async  Task<T> GetEntityWithSpec(ISpecifiation<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async  Task<IReadOnlyList<T>> ListAsync(ISpecifiation<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecifiation<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        private  IQueryable<T> ApplySpecification (ISpecifiation<T> spec)
        {
            return SpecifiationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }

      
    }
}
