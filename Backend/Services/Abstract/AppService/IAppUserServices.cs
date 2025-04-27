using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.AppDtos.AppUserDtos;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract.AppService
{
    public interface IAppUserServices : IBaseServices
    {
        Task<IApiDataResult<List<ListAppUserDtos>>> GetAllUserForAdminPanel();

    }
}
