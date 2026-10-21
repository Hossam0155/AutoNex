using AutoNex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class Shipment
    {
        public int ShipmentId { get; set; }

        public int OrderId { get; set; }

        public string? ShippingCompany { get; set; }

        public string? TrackingNumber { get; set; }

        public string OriginCountry { get; set; } = string.Empty;

        public DateTime? DepartureDate { get; set; }

        public DateTime? ExpectedArrivalDate { get; set; }

        public DateTime? ActualArrivalDate { get; set; }

        public decimal ShippingCost { get; set; }

        public ShipmentStatus Status { get; set; } = ShipmentStatus.Pending;

        public string? Notes { get; set; }

        public Order Order { get; set; } = null!;
    }
}
