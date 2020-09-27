using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using EmplyoeeManagement.Api.Dtos;
using Microsoft.Extensions.Configuration;

namespace EmplyoeeManagement.Api.Helpers
{
    public class ProductUrlResolver : IValueResolver<Products, ProductToreturnDto, string>
    {
        private readonly IConfiguration _config;
        public ProductUrlResolver(IConfiguration config)
        {
            this._config = config;
           
        }


        public string Resolve(Products source, ProductToreturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }
            return null;
        }
    }
}
