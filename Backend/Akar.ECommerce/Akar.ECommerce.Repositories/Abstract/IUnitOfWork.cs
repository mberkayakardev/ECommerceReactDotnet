using Core.Entities.Abstract;
using Core.Repositories.EntityFramework.Abstract;

namespace Akar.ECommerce.Repositories.Abstract
{
    public interface IUnitOfWork 
    {
        #region Costume RepositoryInterfacesProperties


        #endregion
        
        /// <summary>
        ///  Generic Repository For Ef
        /// </summary>
        public IEfGenericRepositories<T> GetEfGenericRepositories<T>() where T: class, IEntity, new () ;
        public Task<int> SaveChangesAsync();
        public void SaveChanges();
    }
}
