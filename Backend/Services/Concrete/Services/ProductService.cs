using AutoMapper;
using Core.Utilities.Results.MVC.BaseResult;
using Core.Utilities.Results.MVC.ComplexTypes;
using Dtos.Concrete.ProductDtos;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Services.Abstract.Base;
using Services.Abstract;
using Services.Concrete.message;

namespace Services.Concrete.Services
{
    public class ProductService : BaseServices, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<IApiDataResult<List<ProductListDto>>> GetAllProductLandingPage()
        {
            var RepositoryData = await _unitOfWork.ProductRepository.GetAllAsync(x=> x.IsActive == true);
            
            if (RepositoryData.Count == 0)
                return new ApiDataResult<List<ProductListDto>>(data : default, status: ApiResultStatus.NotFound, Message: message.Messages.Product.NotFound, Errors:null);

            var mappeddata = _mapper.Map<List<ProductListDto>>(RepositoryData);

            return new ApiDataResult<List<ProductListDto>>(data: mappeddata, status: ApiResultStatus.Ok);

        }
    }
}
