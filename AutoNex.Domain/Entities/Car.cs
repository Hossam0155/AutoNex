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
        public string Make { get; set; } = default!;
        public string Model { get; set; } = default!;
        public int Year { get; set; }
        public string? VIN { get; set; } = default!;
        public string Color { get; set; } = default!;
        public string FuelType { get; set; } = default!;
        public decimal EngineCapacity { get; set; }
        public int MileAge { get; set; }
        public string Condition { get; set; } = default!;
        public string Transmission { get; set; } = default!;    


    }
}
