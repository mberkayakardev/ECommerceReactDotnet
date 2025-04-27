using AutoMapper;
using Core.Entities.Concrete.AppEntities;
using Dtos.Concrete.AppDtos.AppMVCMenusDto;

namespace Services.Concrete.MappingProfiles.MenuProfiles
{
    public class AppMenuProfiles : Profile
    {
        public AppMenuProfiles()
        {
            CreateMap<ListAppMVCMenusDto, AppMVCMenus>().ReverseMap();
        }

    }
}
