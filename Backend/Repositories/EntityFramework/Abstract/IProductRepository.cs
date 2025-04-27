using Core.Repositories.EntityFramework.Abstract;
using Entities.Concrete;

namespace Repositories.EntityFramework.Abstract
{
    public interface IProductRepository : IEfGenericRepositories<Product>
    {

    }
}
