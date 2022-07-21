using Microsoft.EntityFrameworkCore;
using RestaurantMenu.DataAccess.Entities;
using RestaurantMenu.Mapping;

namespace RestaurantMenu
{
    class MenuDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Allergen> Allergens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //mapping settings for category and product
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new GuestMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new AllergenMapping());
            base.OnModelCreating(modelBuilder);
        }

        //use Sql server with this connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string to DB
            optionsBuilder.UseSqlServer(@"Server=.;Database=RestaurantMenuDB;Trusted_Connection=True;");
        }

    }
}
