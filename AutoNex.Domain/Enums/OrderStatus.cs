using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Enums
{
    public enum OrderStatus : byte
    {
        Pending = 0,
        Approved = 1,
        InProgress = 2,
        Completed = 3,
        Cancelled = 4
    }
}
