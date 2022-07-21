using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantMenu.DataAccess.Entities;

namespace RestaurantMenu.Mapping
{
    class AllergenMapping : IEntityTypeConfiguration<Allergen>
    {
        public void Configure(EntityTypeBuilder<Allergen> builder)
        {
            builder.ToTable("Allergen", "dbo");
            builder.HasKey(x => x.AllergenId);
        }

    }
}