using Core.Entities.Abstract;
using Core.Repositories.EntityFramework.Abstract;
using Repositories.EntityFramework.Abstract;

namespace QuizApp.Repositories.EntityFramework.Abstract
{
    public interface IUnitOfWork
    {
        #region Costume Repositories
        IAppUserRepositories AppUserRepositories { get; }

        IProductRepository ProductRepository { get; }
        #endregion
        int SaveChanges();
        Task<int> SaveChangesAsync();
        IEfGenericRepositories<T> GetGenericRepositories<T>() where T : class, IEntity, new();
    }
}
