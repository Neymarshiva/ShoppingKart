using Core.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Specification
{
    public class ProductWithFiltersForCountSpecificication : BaseSpecifiation<Products>
    {
        public ProductWithFiltersForCountSpecificication(ProductSpecParams productParams)
             : base(x =>
              (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains
            (productParams.Search)) &&
             (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
            (!productParams.TypeId.HasValue || x.ProductBrandId == productParams.TypeId))
        {

        }
    }
}
