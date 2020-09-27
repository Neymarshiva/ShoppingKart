using Core.Entities;
using Core.Interfaces;
using Dapper;
using EmplyoeeManagement.Api.Dapper;
using EmplyoeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Api.Data
{
    public class ProductRepository: IProductRepository
    {

        private readonly AppDbContext appDbContext;
        private readonly IDataBaseConnection _db;

        public ProductRepository(AppDbContext _appDbContext, IDataBaseConnection db)
        {
            this.appDbContext = _appDbContext;
            this._db = db;

        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandAsync()
        {
            try
            {
                var result = await _db.Connection.QueryAsync<ProductBrand>("select * from ProductBrand");
                return result.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }

        public async Task<Products> GetProductByIdAsync(int id)
        {

            //var productsList = _db.Connection.Query<Products>("SELECT * FROM Products  WHERE Id=@id",new { id= id }).FirstOrDefault();
            var productsList = await appDbContext.Products.Include(p => p.ProductType).Include(p => p.ProductBrand).
                FirstOrDefaultAsync(x => x.Id == id);
                
            return productsList;
        }

        public async Task<IReadOnlyList<Products>> GetProductsAsync()
        {
            //var productsList =  _db.Connection.Query<Products>("SELECT * FROM Products").ToList();
            var productsList = await appDbContext.Products.Include(p => p.ProductType).Include(p => p.ProductBrand).ToListAsync();
            return productsList;
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypeAsync()
        {
            try
            {
                var result = await _db.Connection.QueryAsync<ProductType>("select * from ProductType");
                return result.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
