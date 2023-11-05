using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class RequestPriceDifference
    {
        public RequestPriceDifference()
        {
            PaymentTrasnsactionRequestPriceDifferences = new HashSet<PaymentTrasnsactionRequestPriceDifference>();
        }

        public int Id { get; set; }
        public double Price { get; set; }
        public int RequestId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int OrderStatus { get; set; }
        public double? AreaDifference { get; set; }
        public string? Description { get; set; }
        public int RequestAreaDifferenceStatus { get; set; }
        public double? SubUnitAreaDifference { get; set; }

        public virtual Request Request { get; set; } = null!;
        public virtual ICollection<PaymentTrasnsactionRequestPriceDifference> PaymentTrasnsactionRequestPriceDifferences { get; set; }
    }
}
