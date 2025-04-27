using Core.Entities.Concrete.AppEntities;
using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.AppDtos.AppMVCMenusDto;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract.AppService
{
    public interface IMenuService : IBaseServices
    {
        Task<IApiDataResult<List<ListAppMVCMenusDto>>> GetAppMVCMenusForUser(int UserId);
    }
}
