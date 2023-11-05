using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class RequestAreaDifferenceStatus
    {
        public int RequestAreaDifferenceReference { get; set; }
        public string RequestAreaDifferenceStatus1 { get; set; } = null!;
    }
}
