using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.ProductDtos;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IProductService 
    {
        Task<IApiDataResult<List<ProductListDto>>> GetAllProductLandingPage();
    }
}
