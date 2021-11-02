using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PringlesDatabase.Models;

namespace PringlesDatabase.Configurations
{
    public class UserConfiguration:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Username).IsUnique();

            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.HasIndex(x => x.Email).IsUnique();


            builder.Property(x => x.PhoneNumber).HasMaxLength(20);


            builder.Property(x => x.CreatedOn).HasDefaultValueSql("GETDATE()");

            builder
                .HasMany(x => x.Ratings)
                .WithOne(x => x.User);

        }
    }
}