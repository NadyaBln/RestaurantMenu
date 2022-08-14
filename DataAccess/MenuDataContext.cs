//using Microsoft.EntityFrameworkCore;
//using RestaurantMenu.DataAccess.Entities;
//using RestaurantMenu.DataAccess.Mapping;

//namespace RestaurantMenu
//{
//    public class MenuDataContext : DbContext
//    {
//        public DbSet<Product> Product { get; set; }
//        public DbSet<Orders> Orders { get; set; }
//        public DbSet<Guest> Guest { get; set; }
//        public DbSet<Category> Category { get; set; }
//        public DbSet<Allergen> Allergen { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            //mapping settings for category and product
//            modelBuilder.ApplyConfiguration(new ProductMapping());
//            modelBuilder.ApplyConfiguration(new OrderMapping());
//            modelBuilder.ApplyConfiguration(new GuestMapping());
//            modelBuilder.ApplyConfiguration(new CategoryMapping());
//            modelBuilder.ApplyConfiguration(new AllergenMapping());
//            base.OnModelCreating(modelBuilder);
//        }

//        //use Sql server with this connection string
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            //connection string to DB
//            optionsBuilder.UseSqlServer(@"Server=.;Database=RestaurantMenuDB;Trusted_Connection=True;");
//        }
//    }
//}
