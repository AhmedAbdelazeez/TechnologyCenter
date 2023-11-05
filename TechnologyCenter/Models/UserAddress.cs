using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class UserAddress
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int? DistrictId { get; set; }
        public int UserProfileId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int RegionId { get; set; }
        public int? SyncStatus { get; set; }
        public int? SyncStatusSa { get; set; }

        public virtual District? District { get; set; }
        public virtual Region Region { get; set; } = null!;
        public virtual UserProfile UserProfile { get; set; } = null!;
    }
}
