using CarRentalLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalLibrary.DataConfiguration
{
    public class EntityPaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);

            builder.Property(e => e.CardHolder)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);  

            builder.Property(e => e.CardNumber)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);  

            builder.Property(e => e.ExpiredDate)
                .IsRequired()
                .HasColumnType("datetime");

        }
    }
}
