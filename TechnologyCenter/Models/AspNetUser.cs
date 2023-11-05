
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class AspNetUser:IdentityUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            ComplaintMakers = new HashSet<Complaint>();
            ComplaintReplies = new HashSet<ComplaintReply>();
            ComplaintUsers = new HashSet<Complaint>();
            InverseMaker = new HashSet<AspNetUser>();
            PaymentTrasnsactions = new HashSet<PaymentTrasnsaction>();
            RefundRequestMakers = new HashSet<RefundRequest>();
            RefundRequestUsers = new HashSet<RefundRequest>();
            Requests = new HashSet<Request>();
            Roles = new HashSet<AspNetRole>();
        }

        public string ArabicFullName { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? MakerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool FirstLogIn { get; set; }
        public int? AddressId { get; set; }
      
        public int? SyncStatus { get; set; }
        public int UserType { get; set; }
        public int? SyncStatusSa { get; set; }

        public virtual Address? Address { get; set; }
        public virtual AspNetUser? Maker { get; set; }
        public virtual UserProfile? UserProfile { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<Complaint> ComplaintMakers { get; set; }
        public virtual ICollection<ComplaintReply> ComplaintReplies { get; set; }
        public virtual ICollection<Complaint> ComplaintUsers { get; set; }
        public virtual ICollection<AspNetUser> InverseMaker { get; set; }
        public virtual ICollection<PaymentTrasnsaction> PaymentTrasnsactions { get; set; }
        public virtual ICollection<RefundRequest> RefundRequestMakers { get; set; }
        public virtual ICollection<RefundRequest> RefundRequestUsers { get; set; }
        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<AspNetRole> Roles { get; set; }
    }
}
