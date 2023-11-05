using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class ShippingPrice
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int ShippingType { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
