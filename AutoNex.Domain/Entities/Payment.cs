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
        public Decimal Amount { get; set; }
        public string Currency { get; set; } = default!;
        public DateTime PaymentDate { get; set; } 
        public string PaymentMethod { get; set; } = default!;
        public string Status { get; set; } = default!;
        public string TransactionReference { get; set; } = default!;
        public string Notes { get; set; } = default!;

        public int ImportOrderId { get; set; }
    }
}
