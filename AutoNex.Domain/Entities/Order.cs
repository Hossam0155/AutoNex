using AutoNex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public string OrderNumber { get; set; } = string.Empty;

        public int CustomerId { get; set; }

        public int CarId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public OrderType OrderType { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public decimal AgreedPrice { get; set; }

        public string CurrencyCode { get; set; } = "EGP";

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public Customer Customer { get; set; } = null!;

        public Car Car { get; set; } = null!;

        public Shipment? Shipment { get; set; }

        public ICollection<Payment> Payments { get; set; }
            = new List<Payment>();

        public Receipt? Receipt { get; set; }
    }
}
