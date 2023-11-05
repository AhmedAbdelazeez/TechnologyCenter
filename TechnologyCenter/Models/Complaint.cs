using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class Complaint
    {
        public Complaint()
        {
            ComplaintReplies = new HashSet<ComplaintReply>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int ComplaintStatus { get; set; }
        public int ComplaintType { get; set; }
        public string MakerId { get; set; } = null!;
        public int? RequestId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public string UserId { get; set; } = null!;

        public virtual AspNetUser Maker { get; set; } = null!;
        public virtual Request? Request { get; set; }
        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<ComplaintReply> ComplaintReplies { get; set; }
    }
}
