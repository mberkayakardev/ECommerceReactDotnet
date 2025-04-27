using Core.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Repositories.EntityFramework.Concrete.EntityConfigurations.AppEntities
{
    public class AppMVCMenusConfigurations : IEntityTypeConfiguration<AppMVCMenus>
    {
        public void Configure(EntityTypeBuilder<AppMVCMenus> builder)
        {
            builder.ToTable("AppMVCMenus");

            builder.HasOne(m => m.ParentMenu)
                   .WithMany(m => m.ChildMenus)
                   .HasForeignKey(m => m.RootId)
                   .OnDelete(DeleteBehavior.Restrict); 


        }
    }
}
