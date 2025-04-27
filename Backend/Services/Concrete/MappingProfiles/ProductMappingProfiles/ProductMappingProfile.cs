using AutoMapper;
using Dtos.Concrete.ProductDtos;
using Entities.Concrete;

namespace Services.Concrete.MappingProfiles.ProductMappingProfiles
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            
            CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
