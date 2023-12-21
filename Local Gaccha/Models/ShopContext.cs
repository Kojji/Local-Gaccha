using Microsoft.EntityFrameworkCore;
namespace Local_Gaccha.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSet>()
                .HasMany(c => c.Products)
                .WithOne(a => a.ProductSet)
                .HasForeignKey(a => a.ProductSetId);

            modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<ProductSet> ProductSets { get; set;}
        public DbSet<Machine> Machines { get; set;}
    }
}
