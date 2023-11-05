using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class PaymentTrasnsactionShippingOrder
    {
        public int PaymentTrasnsactionsId { get; set; }
        public int ShippingOrdersId { get; set; }
        public int? SyncStatus { get; set; }
        public int? SyncStatusSa { get; set; }

        public virtual PaymentTrasnsaction PaymentTrasnsactions { get; set; } = null!;
        public virtual ShippingOrder ShippingOrders { get; set; } = null!;
    }
}
