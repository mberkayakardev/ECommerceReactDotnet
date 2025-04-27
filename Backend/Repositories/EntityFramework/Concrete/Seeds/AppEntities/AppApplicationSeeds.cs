using Core.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppApplicationSeeds : IEntityTypeConfiguration<AppApplicationType>
    {
        public void Configure(EntityTypeBuilder<AppApplicationType> builder)
        {
            builder.HasData(new List<AppApplicationType> { new AppApplicationType
            {
                 Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ApplicationName ="MVC",
                    ApplicationDescription = "MVC"

            },
            new AppApplicationType{
             Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ApplicationName ="React",
                    ApplicationDescription = "React"

            }

            });

        }
}
}
