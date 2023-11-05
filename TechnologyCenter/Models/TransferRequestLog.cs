using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class TransferRequestLog
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public bool HasComplaintsTransfered { get; set; }
        public bool HasPaymentTransactionsTransfered { get; set; }
        public string? OldUserId { get; set; }
        public string? OldUserName { get; set; }
        public string? NewUserId { get; set; }
        public string? NewUserName { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int NumberOfComplaintsTransfered { get; set; }
        public int NumberOfPaymentTransactionsTransfered { get; set; }
    }
}
