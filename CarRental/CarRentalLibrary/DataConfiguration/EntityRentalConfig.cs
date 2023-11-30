using CarRentalLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalLibrary.DataConfiguration
{
    public class EntityRentalConfig : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);

            builder.Property(e => e.UserId)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);  

            builder.Property(e => e.CarId)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);  

            builder.Property(e => e.StartDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(e => e.EndDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(e => e.TotalCost)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");  

            builder.Property(e => e.PaymentId)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);  
        }
    }
}
