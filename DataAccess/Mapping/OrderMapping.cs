using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantMenu.DataAccess.Entities;

namespace RestaurantMenu.DataAccess.Mapping
{
    class OrderMapping : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.ToTable("Order", "dbo");
            builder.HasKey(x => x.OrderId);
        }
    }
}
