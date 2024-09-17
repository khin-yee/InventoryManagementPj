using AutoMapper;
using BlazorApi.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApi.Service
{
    public  class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, ProductCollection>();
        }
    }
}
