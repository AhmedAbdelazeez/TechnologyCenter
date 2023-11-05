using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class Region
    {
        public Region()
        {
            Addresses = new HashSet<Address>();
            Districts = new HashSet<District>();
            Offices = new HashSet<Office>();
            ShippingOrders = new HashSet<ShippingOrder>();
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public int GovernorateId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool? IsNotMilitary { get; set; }

        public virtual Governorate Governorate { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<ShippingOrder> ShippingOrders { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
