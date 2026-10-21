using AutoNex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public string PaymentNumber { get; set; } = string.Empty;

        public int OrderId { get; set; }

        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; } = "EGP";

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public PaymentMethod PaymentMethod { get; set; }

        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

        public string? ReferenceNumber { get; set; }

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Order Order { get; set; } = null!;
    }
}
