using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class InquiryRequest
    {
        public InquiryRequest()
        {
            PaymentTrasnsactions = new HashSet<PaymentTrasnsaction>();
        }

        public int Id { get; set; }
        public int OrderStatus { get; set; }
        public int InquiryRequestStatus { get; set; }
        public int RequestId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public double Price { get; set; }

        public virtual Request Request { get; set; } = null!;
        public virtual ICollection<PaymentTrasnsaction> PaymentTrasnsactions { get; set; }
    }
}
