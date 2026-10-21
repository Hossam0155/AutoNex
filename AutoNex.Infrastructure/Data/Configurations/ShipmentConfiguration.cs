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
    public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.ToTable("Shipments", table =>
            {
                table.HasCheckConstraint(
                    "CK_Shipments_ShippingCost",
                    "[ShippingCost] >= 0");
            });

            builder.HasKey(s => s.ShipmentId);

            builder.HasIndex(s => s.OrderId)
                .IsUnique();

            builder.Property(s => s.ShippingCompany)
                .HasMaxLength(150);

            builder.Property(s => s.TrackingNumber)
                .HasMaxLength(100);

            builder.Property(s => s.OriginCountry)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.DepartureDate)
                .HasColumnType("date");

            builder.Property(s => s.ExpectedArrivalDate)
                .HasColumnType("date");

            builder.Property(s => s.ActualArrivalDate)
                .HasColumnType("date");

            builder.Property(s => s.ShippingCost)
                .HasPrecision(18, 2)
                .HasDefaultValue(0m);

            builder.Property(s => s.Status)
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(s => s.Notes)
                .HasMaxLength(500);

            builder.HasOne(s => s.Order)
                .WithOne(o => o.Shipment)
                .HasForeignKey<Shipment>(s => s.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
