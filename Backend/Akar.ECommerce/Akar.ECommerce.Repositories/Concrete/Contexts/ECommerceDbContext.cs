using Microsoft.EntityFrameworkCore;

namespace Akar.ECommerce.Repositories.Concrete.Contexts
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base (options) 
        { 
        
        
        
        }
    }
}
