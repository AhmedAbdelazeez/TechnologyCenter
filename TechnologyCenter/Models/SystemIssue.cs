using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class SystemIssue
    {
        public int Id { get; set; }
        public int SystemIssueStatus { get; set; }
        public int SystemIssueCreator { get; set; }
        public string? TransactionId { get; set; }
        public string? RequestId { get; set; }
        public string? UserId { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusDescription { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public string? MoreInfo { get; set; }
    }
}
