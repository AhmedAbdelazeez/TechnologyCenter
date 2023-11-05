using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class ShippingOrder
    {
        public ShippingOrder()
        {
            PaymentTrasnsactionShippingOrders = new HashSet<PaymentTrasnsactionShippingOrder>();
        }

        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ShippingType { get; set; }
        public double ShippingPrice { get; set; }
        public int? OfficeId { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int? DistrictId { get; set; }
        public int ShippingOrderStatus { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int NumberOfCopies { get; set; }
        public int? ApartmentNumber { get; set; }
        public string? Description { get; set; }
        public int? FloorNumber { get; set; }
        public int? PropertyNumber { get; set; }
        public int RegionId { get; set; }
        public string? StreetName { get; set; }
        public string? UniqueMark { get; set; }
        public double ExtraCopiesPrice { get; set; }
        public int OrderStatus { get; set; }
        public int? SyncStatus { get; set; }
        public int? SyncStatusSa { get; set; }
        public string? EditCertificateInformation { get; set; }

        public virtual District? District { get; set; }
        public virtual Office? Office { get; set; }
        public virtual Region Region { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
        public virtual ICollection<PaymentTrasnsactionShippingOrder> PaymentTrasnsactionShippingOrders { get; set; }
    }
}
