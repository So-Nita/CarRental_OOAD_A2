using CarRentalLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalLibrary.DataConfiguration
{
    public class EntityUserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100); 

            builder.Property(e => e.Gender)
                .IsRequired()
                .HasColumnType("int")
                .HasConversion<int>();

            builder.Property(e => e.Address)
                .IsRequired(false)
                .HasColumnType("varchar")
                .HasMaxLength(255); 

            builder.Property(e => e.Contact)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);  

            builder.Property(e => e.Email)
                .IsRequired(false)
                .HasColumnType("varchar")
                .HasMaxLength(100);  

            builder.Property(e => e.Password)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);  
        }
    }
}
