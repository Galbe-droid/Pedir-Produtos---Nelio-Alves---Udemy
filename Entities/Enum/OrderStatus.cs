using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsOrdering.Entities.Enum
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
