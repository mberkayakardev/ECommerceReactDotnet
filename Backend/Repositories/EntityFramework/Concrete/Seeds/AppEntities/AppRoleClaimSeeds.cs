using Core.Entities.Abstract;
using Core.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppRoleClaimSeeds : IEntityTypeConfiguration<AppRoleClaim>
    {
        public void Configure(EntityTypeBuilder<AppRoleClaim> builder)
        {
            List<AppRoleClaim> AppRoleClaimList = new()
            {
            };


            builder.HasData(AppRoleClaimList);
        }
    }
}
