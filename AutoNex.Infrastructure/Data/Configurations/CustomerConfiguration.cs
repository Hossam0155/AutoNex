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
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.FullName)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(c => c.PhoneNumber)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(150);

            builder.Property(c => c.Address)
                .HasMaxLength(150);

            builder.Property(c => c.CreatedAt)
                .HasColumnType("datetime2(0)")
                .IsRequired();

            builder.Property(c => c.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(c => c.PhoneNumber);
        }
    }
}
