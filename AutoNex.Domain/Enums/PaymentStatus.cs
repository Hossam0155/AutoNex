using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Enums
{
    public enum PaymentStatus : byte
    {
        Pending = 0,
        Confirmed = 1,
        Cancelled = 2,
        Reversed = 3
    }
}
