using AutoNex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Infrastructure.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars", table =>
            {
                table.HasCheckConstraint(
                    "CK_Cars_Price",
                    "[Price] >= 0");

                table.HasCheckConstraint(
                    "CK_Cars_Year",
                    "[Year] BETWEEN 1950 AND 2100");
            });

            builder.HasKey(c => c.CarId);

            builder.Property(c => c.Brand)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Model)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.VIN)
                .HasColumnType("varchar(17)")
                .IsUnicode(false)
                .HasMaxLength(17);

            builder.HasIndex(c => c.VIN)
                .IsUnique()
                .HasFilter("[VIN] IS NOT NULL");

            builder.Property(c => c.Color)
                .HasMaxLength(50);

            builder.Property(c => c.SourceType)
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(c => c.Status)
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(c => c.Price)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(c => c.CurrencyCode)
                .HasColumnType("char(3)")
                .IsUnicode(false)
                .IsRequired();

            builder.Property(c => c.CreatedAt)
                .HasColumnType("datetime2(0)")
                .IsRequired();
        }
    }
 
}
