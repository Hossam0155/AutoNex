using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Enums
{
    public enum ShipmentStatus : byte
    {
        Pending = 0,
        Shipped = 1,
        InTransit = 2,
        Arrived = 3,
        Cancelled = 4
    }
}
