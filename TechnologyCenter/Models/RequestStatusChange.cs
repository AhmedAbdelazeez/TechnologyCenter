using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class RequestStatusChange
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int PreviousStatus { get; set; }
        public string? StatusDescription { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int NewStatus { get; set; }
        public DateTime StatusChangeDate { get; set; }

        public virtual Request Request { get; set; } = null!;
    }
}
