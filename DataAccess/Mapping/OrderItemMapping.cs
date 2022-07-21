using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantMenu.DataAccess.Entities;

namespace RestaurantMenu.DataAccess.Mapping
{
    class OrderItemMapping : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem", "dbo");
            builder.HasKey(x => x.OrderItemId);
        }
    }
}
