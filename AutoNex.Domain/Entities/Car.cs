using AutoNex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; } = default!;
        public string Model { get; set; } = default!;
        public short Year { get; set; }
        public string? VIN { get; set; } 
        public string? Color { get; set; }
        public CarSourceType SourceType { get; set; }
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "EGP";
        public CarStatus Status { get; set; } = CarStatus.Available;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
