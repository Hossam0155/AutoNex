using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class Receipt
    {
        public int ReceiptId { get; set; }

        public string ReceiptNumber { get; set; } = string.Empty;

        public int OrderId { get; set; }

        public decimal TotalAmount { get; set; }

        public string CurrencyCode { get; set; } = "EGP";

        public DateTime IssueDate { get; set; } = DateTime.UtcNow;

        public string IssuedBy { get; set; } = string.Empty;

        public bool IsVoided { get; set; }

        public string? Notes { get; set; }

        public Order Order { get; set; } = null!;
    }
}
