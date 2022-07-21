using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantMenu.DataAccess.Entities;

namespace RestaurantMenu.DataAccess.Mapping
{
    class GuestMapping : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.ToTable("Guest", "dbo");
            builder.HasKey(x => x.GuestId);
        }
    }
}
