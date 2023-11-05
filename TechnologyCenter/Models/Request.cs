using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class Request
    {
        public Request()
        {
            Complaints = new HashSet<Complaint>();
            PaymentTrasnsactions = new HashSet<PaymentTrasnsaction>();
            RefundRequests = new HashSet<RefundRequest>();
            RequestPriceDifferences = new HashSet<RequestPriceDifference>();
            RequestStatusChanges = new HashSet<RequestStatusChange>();
            ShippingOrders = new HashSet<ShippingOrder>();
        }

        public int Id { get; set; }
        public int UnitType { get; set; }
        public int RequestStatus { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public string? RequestNumber { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int? AreaType { get; set; }
        public int? SyncStatus { get; set; }
        public bool? HasPriceDifference { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsArchived { get; set; }
        public int? SyncStatusSa { get; set; }
        public int? SubUnitType { get; set; }
        public double? SubUnitTypeArea { get; set; }
        public double CrewTransferCost { get; set; }
        public string? StatusDescription { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? BuildingArea { get; set; }
        public string? LandArea { get; set; }
        public bool? HasInquiryRequest { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual Address? Address { get; set; }
        public virtual InquiryRequest? InquiryRequest { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual ICollection<PaymentTrasnsaction> PaymentTrasnsactions { get; set; }
        public virtual ICollection<RefundRequest> RefundRequests { get; set; }
        public virtual ICollection<RequestPriceDifference> RequestPriceDifferences { get; set; }
        public virtual ICollection<RequestStatusChange> RequestStatusChanges { get; set; }
        public virtual ICollection<ShippingOrder> ShippingOrders { get; set; }
    }
}
