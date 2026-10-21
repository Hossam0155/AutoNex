using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNex.Domain.Enums
{
    public enum PaymentMethod : byte
    {
        Cash = 0,
        BankTransfer = 1,
        Card = 2,
        Other = 3
    }
}
