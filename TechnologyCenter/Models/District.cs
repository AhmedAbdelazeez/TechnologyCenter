using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class District
    {
        public District()
        {
            Addresses = new HashSet<Address>();
            ShippingOrders = new HashSet<ShippingOrder>();
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public int RegionId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<ShippingOrder> ShippingOrders { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
