using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class UserProfile
    {
        public int Id { get; set; }
        public string TelephoneNumber { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? HasWhatsApp { get; set; }
        public int PhoneNumberType { get; set; }
        public int? SyncStatus { get; set; }
        public string? Description { get; set; }
        public int? SyncStatusSa { get; set; }
        public bool? HasAnotherNumber { get; set; }
        public bool? HasWhatsApp2 { get; set; }
        public int? PhoneNumberType2 { get; set; }
        public string? TelephoneNumber2 { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual UserAddress? UserAddress { get; set; }
    }
}
