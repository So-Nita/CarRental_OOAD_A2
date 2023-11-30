using CarRentalLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary.DataConfiguration
{
    public class EntityCarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasIndex(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);

            builder.Property(e => e.Model)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(e => e.Year)
                .IsRequired()
                .HasColumnType("varchar");

            builder.Property(e => e.Type)
                .IsRequired()
                .HasColumnType("int")  
                .HasConversion<int>();

            builder.Property(e => e.Capacity)
                .IsRequired()
                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.PricePerDay)
                .IsRequired()
                .HasColumnType("decimal(8,2)")
                .HasMaxLength(36);

            builder.Property(e => e.Color)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(36);

            builder.Property(e => e.Brand)
                .IsRequired()
                .HasColumnType("int")  
                .HasConversion<int>();
        }

    }
}
