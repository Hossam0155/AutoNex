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
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string NationalId { get; set; } = default!;
        public string? Address { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public string? IsActive { get; set; } = default!;

      
    }
}
