using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class ImportExpense
    {
        public int ExpenseId { get; set; }
        public string ExpenseType { get; set; } = default!;
        public decimal Amount { get; set; }
        public string Currency { get; set; } = default!;
        public DateTime ExpenseDate { get; set; }
        public string Description { get; set; } = default!;
        public string ReceiptNumber { get; set; } = default!;
        public int ImportOrderId { get; set; }
    }
}
