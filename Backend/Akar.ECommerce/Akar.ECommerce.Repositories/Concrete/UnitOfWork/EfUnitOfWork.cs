using Akar.ECommerce.Repositories.Abstract;
using Akar.ECommerce.Repositories.Concrete.Contexts;
using Core.Repositories.EntityFramework.Abstract;
using Core.Repositories.EntityFramework.Concrete;

namespace Akar.ECommerce.Repositories.Concrete.UnitOfWork
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbContext _context;
        public EfUnitOfWork(ECommerceDbContext context)
        {
            _context = context;
        }


        #region Costume Repository Interface Properties



        #endregion
        public void SaveChanges()
        {
            _context.SaveChanges(); 
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        IEfGenericRepositories<T> IUnitOfWork.GetEfGenericRepositories<T>()
        {
            return new EfGenericRepositories<T>(_context);
        }
    }
}
