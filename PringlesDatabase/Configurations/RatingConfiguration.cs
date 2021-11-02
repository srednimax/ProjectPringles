using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PringlesDatabase.Models;

namespace PringlesDatabase.Configurations
{
    public class RatingConfiguration:IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Ratings");

            builder.Property(x => x.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.Score).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
        }
    }
}