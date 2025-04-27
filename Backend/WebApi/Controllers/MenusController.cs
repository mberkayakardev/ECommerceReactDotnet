using Core.Extentions.Concrete.Controller.Api;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizApp.Services.Abstract;
using Services.Abstract.AppService;
using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;

namespace WebApi.Controllers
{
    [Authorize]
    public class MenusController : CostumeApiController
    {
        private readonly IMenuService _MenuService;
        public MenusController(IMenuService menuService)
        {
            _MenuService = menuService;
        }



        [HttpGet("MVC/{UserId}")]
        public async Task<IActionResult> Index(int UserId)
        {
            return ActionResultInstance(await _MenuService.GetAppMVCMenusForUser(UserId));
        }
    }
}
