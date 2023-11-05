using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class Address
    {
        public Address()
        {
            AspNetUsers = new HashSet<AspNetUser>();
        }

        public int Id { get; set; }
        public string? PropertyNumber { get; set; }
        public int? FloorNumber { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? StreetName { get; set; }
        public string UniqueMark { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? DistrictId { get; set; }
        public int RequestId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int RegionId { get; set; }
        public int? SyncStatus { get; set; }
        public int? SyncStatusSa { get; set; }
        public string? FloorNumberText { get; set; }
        public string EasternBorder { get; set; } = null!;
        public string EasternBorderLength { get; set; } = null!;
        public string MaritimeBorder { get; set; } = null!;
        public string MaritimeBorderLength { get; set; } = null!;
        public string TribalBorder { get; set; } = null!;
        public string TribalBorderLength { get; set; } = null!;
        public string WesternBorder { get; set; } = null!;
        public string WesternBorderLength { get; set; } = null!;

        public virtual District? District { get; set; }
        public virtual Region Region { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
