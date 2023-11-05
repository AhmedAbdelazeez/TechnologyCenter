using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class PaymentTrasnsactionRequestPriceDifference
    {
        public int PaymentTrasnsactionsId { get; set; }
        public int RequestPriceDifferencesId { get; set; }
        public int? SyncStatus { get; set; }
        public int? SyncStatusSa { get; set; }

        public virtual PaymentTrasnsaction PaymentTrasnsactions { get; set; } = null!;
        public virtual RequestPriceDifference RequestPriceDifferences { get; set; } = null!;
    }
}
