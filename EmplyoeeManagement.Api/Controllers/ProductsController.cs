using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using EmplyoeeManagement.Api.Dtos;
using EmplyoeeManagement.Api.Errors;
using EmplyoeeManagement.Api.Helpers;
using EmplyoeeManagement.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmplyoeeManagement.Api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ProductsController : BaseApiController
    {
        private readonly IGenericRepository<Products> _productsRepo;
        private readonly IGenericRepository<ProductType> _productsTypeRepo;
        private readonly IGenericRepository<ProductBrand> _productsBrandRepo;
        private readonly IMapper _mapper;


        public ProductsController(IGenericRepository<Products> productsRepo, 
            IGenericRepository<ProductType> productsTypeRepo,
            IGenericRepository<ProductBrand> productsBrandRepo,IMapper mapper)
        {
            this._productsRepo = productsRepo;
            this._productsTypeRepo = productsTypeRepo;
            this._productsBrandRepo = productsBrandRepo;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Pagination<ProductToreturnDto>>> GetProducts(
           [FromQuery]ProductSpecParams productParams)
        {
            try
            {
                var spec = new ProductsWithTypesAndBrandsSpecification(productParams);
                var countSpec = new ProductWithFiltersForCountSpecificication(productParams);

                //var listProducts = await _productsRepo.ListAllAsync();
               // var listProducts = await _productsRepo.ListAsync(spec);

                var totalItems = await _productsRepo.CountAsync(countSpec);
                var products = await _productsRepo.ListAsync(spec);

                var data = _mapper
                    .Map<IReadOnlyList<Products>, IReadOnlyList<ProductToreturnDto>>(products);

                return Ok(new Pagination<ProductToreturnDto>(productParams.PageIndex, productParams.PageSize, totalItems, data));
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductToreturnDto>> GetProducts(int id)
        {
            try
            {
                var spec = new ProductsWithTypesAndBrandsSpecification(id);

                //var products = await _productsRepo.GetByIdAsync(id);
                var products = await _productsRepo.GetEntityWithSpec(spec);

                if (products == null) return NotFound(new ApiResponse(404));

                return _mapper.Map<Products, ProductToreturnDto>(products);

                //return new ProductToreturnDto
                //{
                //    Id = products.Id,
                //    Name = products.Name,
                //    Description = products.Description,
                //    PictureUrl = products.PictureUrl,
                //    Price = products.Price,
                //    ProductBrand = products.ProductBrand.Name,
                //    ProductType = products.ProductType.Name
                //};
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            try
            {
                var result = await _productsBrandRepo.ListAllAsync();
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            try
            {
                return Ok(await _productsTypeRepo.ListAllAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}