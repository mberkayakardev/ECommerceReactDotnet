using ApiService.Entities.Concrete.AppEntities;
using Core.Dtos.Concrete;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract.AppService
{
    public interface ITokenService : IBaseServices
    {
        TokenDto CreateToken(AppUser userApp);
        ClientTokenDto CreateTokenByClient(Client client);

    }
}
