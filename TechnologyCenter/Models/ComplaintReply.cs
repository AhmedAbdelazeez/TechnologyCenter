using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class ComplaintReply
    {
        public int Id { get; set; }
        public int ComplaintId { get; set; }
        public string Content { get; set; } = null!;
        public string MakerId { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual Complaint Complaint { get; set; } = null!;
        public virtual AspNetUser Maker { get; set; } = null!;
    }
}
