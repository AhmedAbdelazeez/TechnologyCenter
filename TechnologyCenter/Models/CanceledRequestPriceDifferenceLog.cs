using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class CanceledRequestPriceDifferenceLog
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public bool HasFawryPaymentTransactions { get; set; }
        public double Price { get; set; }
        public double AreaDifference { get; set; }
        public double SubUnitAreaDifference { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
