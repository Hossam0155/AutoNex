using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; } = default!;
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string NationalId { get; set; } = default!;
        public string? Address { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        public ICollection<Order> Orders { get; set; }
          = new List<Order>();
    }
}
