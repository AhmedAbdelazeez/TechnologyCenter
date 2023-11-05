using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class RefundRequest
    {
        public int Id { get; set; }
        public int RefundReason { get; set; }
        public string? OtherRefundReason { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string Ssn { get; set; } = null!;
        public int RequestId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public string? MakerId { get; set; }
        public string UserId { get; set; } = null!;
        public int PaymentTrasnsactionId { get; set; }
        public int RefundStatus { get; set; }
        public string? RefundManagerComment { get; set; }
        public string? ReviewerComment { get; set; }
        public string Iban { get; set; } = null!;

        public virtual AspNetUser? Maker { get; set; }
        public virtual PaymentTrasnsaction PaymentTrasnsaction { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
