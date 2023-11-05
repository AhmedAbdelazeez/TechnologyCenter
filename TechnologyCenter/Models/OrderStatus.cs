using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class OrderStatus
    {
        public int OrderStatusReference { get; set; }
        public string OrderStatusName { get; set; } = null!;
    }
}
