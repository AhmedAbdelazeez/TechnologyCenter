using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class Governorate
    {
        public Governorate()
        {
            Regions = new HashSet<Region>();
        }

        public int Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public double CrewTransferCost { get; set; }

        public virtual ICollection<Region> Regions { get; set; }
    }
}
