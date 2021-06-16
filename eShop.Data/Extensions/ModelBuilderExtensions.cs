using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeTitle2", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeTitle3", Value = "This is home page of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
               new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
               new Language() { Id = "en-US", Name = "English", IsDefault = false }
               );

            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 1,
                   IsShowOnHome = true,
                   ParentId = null,
                   SortOrder = 1,
                   Status = Status.Active,
               },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                }
               );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                 new CategoryTranslation()
                 {
                     Id = 1,
                     CategoryId = 1,
                     Name = "Áo nam",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-nam",
                     SeoDescription = "Sản phẩm áo thời trang nam",
                     SeoTitle = "Sản phẩm áo thời trang nam"
                 },
                 new CategoryTranslation()
                 {
                     Id = 2,
                     CategoryId = 1,
                     Name = "Men shirt",
                     LanguageId = "en-US",
                     SeoAlias = "men-shirt",
                     SeoDescription = "The shirt products for men",
                     SeoTitle = "The shirt products for men"
                 },
                  new CategoryTranslation()
                  {
                      Id = 3,
                      CategoryId = 2,
                      Name = "Áo nữ",
                      LanguageId = "vi-VN",
                      SeoAlias = "ao-nu",
                      SeoDescription = "Sản phẩm áo thời trang nữ",
                      SeoTitle = "Sản phẩm áo thời trang nu"
                  },
                  new CategoryTranslation()
                  {
                      Id = 4,
                      CategoryId = 2,
                      Name = "Women shirt",
                      LanguageId = "en-US",
                      SeoAlias = "women-shirt",
                      SeoDescription = "The shirt products for women",
                      SeoTitle = "The shirt products for women"
                  }
                );

            modelBuilder.Entity<Product>().HasData(
              new Product()
              {
                  Id = 1,
                  DateCreated = DateTime.Now,
                  OriginalPrice = 100000,
                  Price = 200000,
                  Stock = 0,
                  ViewCount = 0,
              }
            );
            modelBuilder.Entity<ProductTranslation>().HasData(

                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam-viet-tien",
                    SeoDescription = "Sản phẩm áo sơ mi nam Việt Tiến",
                    SeoTitle = "Sản phẩm áo sơ mi nam Việt Tiến",
                    Details = "Sản phẩm áo sơ mi nam Việt Tiến",
                    Description = "Sản phẩm áo sơ mi nam Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men shirt",
                    LanguageId = "en-US",
                    SeoAlias = "Viet-tien-men-shirt",
                    SeoDescription = "Viet Tien Men shirt",
                    SeoTitle = "Viet Tien Men shirt",
                    Details = "Viet Tien Men shirt",
                    Description = "Viet Tien Men shirt"
                }
            );

            modelBuilder.Entity<ProductInCategory>().HasData
                (
                    new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("8699EF4A-3FE5-4A6A-9525-B007F2002265");
            var adminId = new Guid("925948CC-A1E0-4162-AEEB-86DC1262D9AD");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            }); 

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "levothang.99@gmail.com",
                NormalizedEmail = "levothang.99@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                FirstName = "Thang",
                LastName = "Vo",
                Dob = new DateTime(1999, 01, 31)
            }
            );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}