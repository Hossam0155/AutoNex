using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Enums
{
    public enum CarStatus : byte
    {
        Available = 0,
        Reserved = 1,
        InTransit = 2,
        Arrived = 3,
        Sold = 4
    }
}
