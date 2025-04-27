using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds
{
    public class ProductsSeedsDatas : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            List<Product> ProductList = new()
            {
                new ()
                {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    ModifiedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserName = "SeedData",
                    ProductName = "Telefon",
                    ProductDescription = "Telefon",
                    ProductDescriptionForTextEdit = "Telefon",
                    ProductPrice = 15000,
                    Stock = 20
                },
                 new ()
                {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    ModifiedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserName = "SeedData",
                    ProductName = "Tablet",
                    ProductDescription = "Tablet",
                    ProductDescriptionForTextEdit = "Tablet",
                    ProductPrice = 15000,
                    Stock = 20
                },

                 new ()
                {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    ModifiedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserName = "SeedData",
                    ProductName = "Masaüstü PC",
                    ProductDescription = "Masaüstü PC",
                    ProductDescriptionForTextEdit = "Masaüstü PC",
                    ProductPrice = 15000,
                    Stock = 20
                },
            };

            builder.HasData(ProductList);
        }
    }
}
