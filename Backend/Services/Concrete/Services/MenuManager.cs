using AutoMapper;
using Core.Utilities.Results.MVC.BaseResult;
using Core.Utilities.Results.MVC.ComplexTypes;
using Dtos.Concrete.AppDtos.AppMVCMenusDto;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Services.Abstract.Base;
using Services.Abstract.AppService;
using static Services.Concrete.message.Messages;

namespace Services.Concrete.Services
{
    public class MenuManager : BaseServices, IMenuService
    {
        public MenuManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<IApiDataResult<List<ListAppMVCMenusDto>>> GetAppMVCMenusForUser(int UserId)
        {
            var UserMenus = await _unitOfWork.AppUserRepositories.GetAppMVCMenusForUser(UserId);
            if (UserMenus.Count == 0 ) 
                return new ApiDataResult<List<ListAppMVCMenusDto>>(default, ApiResultStatus.NotFound, Menus.NotFound);

            var mappedData = _mapper.Map<List<ListAppMVCMenusDto>>(UserMenus);

            return new ApiDataResult<List<ListAppMVCMenusDto>>(mappedData, ApiResultStatus.Ok);
        }
    }
}
