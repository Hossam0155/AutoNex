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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments", table =>
            {
                table.HasCheckConstraint(
                    "CK_Payments_Amount",
                    "[Amount] > 0");
            });

            builder.HasKey(p => p.PaymentId);

            builder.Property(p => p.PaymentNumber)
                .HasColumnType("varchar(30)")
                .IsUnicode(false)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(p => p.PaymentNumber)
                .IsUnique();

            builder.Property(p => p.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(p => p.CurrencyCode)
                .HasColumnType("char(3)")
                .IsUnicode(false)
                .IsRequired();

            builder.Property(p => p.PaymentDate)
                .HasColumnType("datetime2(0)")
                .IsRequired();

            builder.Property(p => p.PaymentMethod)
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(p => p.Status)
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(p => p.ReferenceNumber)
                .HasMaxLength(100);

            builder.Property(p => p.Notes)
                .HasMaxLength(500);

            builder.Property(p => p.CreatedAt)
                .HasColumnType("datetime2(0)")
                .IsRequired();

            builder.HasOne(p => p.Order)
                .WithMany(o => o.Payments)
                .HasForeignKey(p => p.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(p => new { p.OrderId, p.Status });
        }
    }
}
