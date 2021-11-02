using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PringlesDatabase.Models;

namespace PringlesDatabase.Configurations
{
    public class PringlesConfiguration: IEntityTypeConfiguration<Pringles>
    {
        public void Configure(EntityTypeBuilder<Pringles> builder)
        {
            builder.ToTable("Pringles");

            builder.Property(x => x.Flavor).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Description);
            builder.HasIndex(x => x.Flavor).IsUnique();
            

            builder
                .HasMany(x => x.Ratings)
                .WithOne(x => x.Pringles);
        }
    }
}