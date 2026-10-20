using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class ImportOrder
    {
        public int ImportOrderId { get; set; }
        public string OrderNumber { get; set; } = default!;
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = default!;
        public Decimal PurchasePrice { get; set; }
        public string Currency { get; set; } = default!;
        public decimal ExchangeRate { get; set; }
        public Decimal EstimatedTotalCost { get; set; }
        public string? Notes { get; set; } = default!;

        public int CustomerId { get; set; }
        public int CarId { get; set; }
    }
}
