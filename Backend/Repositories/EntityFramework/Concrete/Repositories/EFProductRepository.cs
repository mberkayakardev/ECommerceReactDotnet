using Core.Repositories.EntityFramework.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Repositories.EntityFramework.Abstract;

namespace Repositories.EntityFramework.Concrete.Repositories
{
    public class EFProductRepository : EfGenericRepositories<Product>, IProductRepository
    {
        public EFProductRepository(DbContext context) : base(context)
        {

        }
    }
}
