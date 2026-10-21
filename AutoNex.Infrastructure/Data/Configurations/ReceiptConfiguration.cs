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
    public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.ToTable("Receipts", table =>
            {
                table.HasCheckConstraint(
                    "CK_Receipts_TotalAmount",
                    "[TotalAmount] > 0");
            });

            builder.HasKey(r => r.ReceiptId);

            builder.Property(r => r.ReceiptNumber)
                .HasColumnType("varchar(30)")
                .IsUnicode(false)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(r => r.ReceiptNumber)
                .IsUnique();

            builder.HasIndex(r => r.OrderId)
                .IsUnique();

            builder.Property(r => r.TotalAmount)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(r => r.CurrencyCode)
                .HasColumnType("char(3)")
                .IsUnicode(false)
                .IsRequired();

            builder.Property(r => r.IssueDate)
                .HasColumnType("datetime2(0)")
                .IsRequired();

            builder.Property(r => r.IssuedBy)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(r => r.IsVoided)
                .HasDefaultValue(false);

            builder.Property(r => r.Notes)
                .HasMaxLength(500);

            builder.HasOne(r => r.Order)
                .WithOne(o => o.Receipt)
                .HasForeignKey<Receipt>(r => r.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
