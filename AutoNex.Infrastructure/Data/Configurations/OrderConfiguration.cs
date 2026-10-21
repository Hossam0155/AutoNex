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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", table =>
            {
                table.HasCheckConstraint(
                    "CK_Orders_AgreedPrice",
                    "[AgreedPrice] > 0");
            });

            builder.HasKey(o => o.OrderId);

            builder.Property(o => o.OrderNumber)
                .HasColumnType("varchar(30)")
                .IsUnicode(false)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(o => o.OrderNumber)
                .IsUnique();

            builder.Property(o => o.OrderDate)
                .HasColumnType("datetime2(0)")
                .IsRequired();

            builder.Property(o => o.OrderType)
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(o => o.Status)
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(o => o.AgreedPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(o => o.CurrencyCode)
                .HasColumnType("char(3)")
                .IsUnicode(false)
                .IsRequired();

            builder.Property(o => o.Notes)
                .HasMaxLength(500);

            builder.Property(o => o.CreatedAt)
                .HasColumnType("datetime2(0)")
                .IsRequired();

            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Car)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(o => o.CarId)
                .IsUnique()
                .HasFilter("[Status] <> 4");

            builder.HasIndex(o => new { o.CustomerId, o.OrderDate });
        }
    }
}
