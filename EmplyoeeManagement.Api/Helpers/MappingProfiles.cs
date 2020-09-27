using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using EmplyoeeManagement.Api.Dtos;

namespace EmplyoeeManagement.Api.Helpers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Products, ProductToreturnDto>()
                .ForMember(d => d.ProductBrand, x => x.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, x => x.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, x => x.MapFrom<ProductUrlResolver>());
        }

    }
}
