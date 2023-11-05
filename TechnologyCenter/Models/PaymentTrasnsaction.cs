using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class PaymentTrasnsaction
    {
        public PaymentTrasnsaction()
        {
            PaymentTrasnsactionRequestPriceDifferences = new HashSet<PaymentTrasnsactionRequestPriceDifference>();
            PaymentTrasnsactionShippingOrders = new HashSet<PaymentTrasnsactionShippingOrder>();
            RefundRequests = new HashSet<RefundRequest>();
        }

        public int Id { get; set; }
        public Guid MerchantRefNum { get; set; }
        public double Price { get; set; }
        public double? PaymentAmount { get; set; }
        public double? FawryFees { get; set; }
        public int? PaymentMethod { get; set; }
        public int? OrderStatus { get; set; }
        public string? ReferenceNumber { get; set; }
        public DateTime? PaymentTime { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusDescription { get; set; }
        public int RequestId { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int TransactionType { get; set; }
        public double? RefundedAmount { get; set; }
        public int? SyncStatus { get; set; }
        public int? SyncStatusSa { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? InquiryRequestId { get; set; }
        public int FawryAccountType { get; set; }

        public virtual InquiryRequest? InquiryRequest { get; set; }
        public virtual Request Request { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<PaymentTrasnsactionRequestPriceDifference> PaymentTrasnsactionRequestPriceDifferences { get; set; }
        public virtual ICollection<PaymentTrasnsactionShippingOrder> PaymentTrasnsactionShippingOrders { get; set; }
        public virtual ICollection<RefundRequest> RefundRequests { get; set; }
    }
}
