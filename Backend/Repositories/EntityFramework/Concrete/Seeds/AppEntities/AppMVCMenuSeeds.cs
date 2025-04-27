using Core.Entities.Concrete.AppEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppMVCMenuSeeds : IEntityTypeConfiguration<AppMVCMenus>
    {
        public void Configure(EntityTypeBuilder<AppMVCMenus> builder)
        {
            List<AppMVCMenus> appMVCMenus = new List<AppMVCMenus>{
            };


            builder.HasData(appMVCMenus);



        }
    }
}
