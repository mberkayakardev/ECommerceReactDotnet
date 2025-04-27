using ApiService.Entities.Concrete.AppEntities;
using AutoMapper;
using Core.Utilities.Results.MVC.BaseResult;
using Core.Utilities.Results.MVC.ComplexTypes;
using Dtos.Concrete.AppDtos.AppUserDtos;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Services.Abstract.Base;
using Services.Abstract.AppService;
using static Services.Concrete.message.Messages;

namespace QuizApp.Services.Concrete.Services
{
    public class AppUserManagers : BaseServices, IAppUserServices
    {
        public AppUserManagers(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<IApiDataResult<List<ListAppUserDtos>>> GetAllUserForAdminPanel()
        {
            var Entities = await _unitOfWork.GetGenericRepositories<AppUser>().GetAllAsync();
            if (Entities.Count == 0)
                return new ApiDataResult<List<ListAppUserDtos>>(default, ApiResultStatus.NotFound, AdminModule.NotFoundUsers);


            var mappeddata = _mapper.Map<List<ListAppUserDtos>>(Entities);
            return new ApiDataResult<List<ListAppUserDtos>>(mappeddata, ApiResultStatus.Ok);


        }
    }
}
