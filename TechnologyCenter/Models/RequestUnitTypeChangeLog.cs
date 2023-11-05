using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class RequestUnitTypeChangeLog
    {
        public int Id { get; set; }
        public int NewUnitType { get; set; }
        public int OldUnitType { get; set; }
        public int? NewAreaType { get; set; }
        public int? OldAreaType { get; set; }
        public int? NewSubUnitType { get; set; }
        public int? OldSubUnitType { get; set; }
        public double Area { get; set; }
        public double? NewSubUnitTypeArea { get; set; }
        public double? OldSubUnitTypeArea { get; set; }
        public double Price { get; set; }
        public string? RequestNumber { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int RequestId { get; set; }
    }
}
