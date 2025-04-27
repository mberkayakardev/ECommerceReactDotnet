using Core.Utilities.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Middlewares.MVC
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

            }
            catch (SessionExpiredException)
            {
                context.Response.Redirect("/Admin/Account/SingOut");
            }
            catch (Exception)
            {
                context.Response.Redirect("/Error/500");
            }
        }
    }
}
