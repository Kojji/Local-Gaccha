using Microsoft.EntityFrameworkCore;

namespace Local_Gaccha.Models
{
    public static class ModelSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSet>().HasData(
                new ProductSet { Id = 1, Name = "Gacha Set - example 1" },
                new ProductSet { Id = 2, Name = "Gacha Set - example 2" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductSetId = 1, Name = "Product 1", Sku = "AWMGSJ", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 2, ProductSetId = 1, Name = "Product 2", Sku = "AWMPSU", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 3, ProductSetId = 1, Name = "Product 3", Sku = "AWMSGT", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 4, ProductSetId = 1, Name = "Product 4", Sku = "AWMSJY", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 5, ProductSetId = 1, Name = "Product 5", Sku = "AWMTFJ", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 6, ProductSetId = 1, Name = "Product 6", Sku = "AWMUTV", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 7, ProductSetId = 1, Name = "Product 7", Sku = "AWMVNP", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 8, ProductSetId = 1, Name = "Product 8", Sku = "AWMVNS", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 9, ProductSetId = 1, Name = "Product 9", Sku = "AWMVNT", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 10, ProductSetId = 2, Name = "Product 10", Sku = "AWWBTS", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 11, ProductSetId = 2, Name = "Product 11", Sku = "AWWCTT", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 12, ProductSetId = 2, Name = "Product 12", Sku = "AWWGSJ", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 13, ProductSetId = 2, Name = "Product 13", Sku = "AWWSJU", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 14, ProductSetId = 2, Name = "Product 14", Sku = "AWWSDP", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 15, ProductSetId = 2, Name = "Product 15", Sku = "AWWUTT", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 16, ProductSetId = 2, Name = "Product 16", Sku = "AWWUTV", ImageUrl = "", Type = "Gacha" },
                new Product { Id = 17, ProductSetId = 2, Name = "Product 17", Sku = "AWWVNT", ImageUrl = "", Type = "Gacha" });
        }
    }
}
