using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class Office
    {
        public Office()
        {
            ShippingOrders = new HashSet<ShippingOrder>();
        }

        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string ArabicAddress { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public string EnglishAddress { get; set; } = null!;
        public int RegionId { get; set; }
        public string Gpslocation { get; set; } = null!;

        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<ShippingOrder> ShippingOrders { get; set; }
    }
}
