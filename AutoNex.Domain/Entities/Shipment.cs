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
        public string TrackingNumber { get; set; } = default!;
        public string ShippingCompany { get; set; } = default!;
        public string OriginCountry { get; set; } = default!;
        public string PortOfLoading { get; set; } = default!;
        public string DestinationPort { get; set; } = default!;
        public DateTime ShipmentDate { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }
        public DateTime ActualArrivalDate { get; set; }
        public string Status { get; set; } = default!;

        public int ImportOrderId { get; set; }
    }
}
