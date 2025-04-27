using Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppClaimsSeeds : IEntityTypeConfiguration<AppClaim>
    {
        public void Configure(EntityTypeBuilder<AppClaim> builder)
        {
            var AppClaimList = new List<AppClaim>
            {
                new AppClaim {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.Dashboard",
                    ClaimDescription = "Admin Layout içerisindeki Dashboard ın görülebilmesi için eklenmiş olan bir cliam dir."
                }
            };

            builder.HasData(AppClaimList);
        }
    }
}
