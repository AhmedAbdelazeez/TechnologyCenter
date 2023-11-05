using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class AreaType
    {
        public int AreaTypeReference { get; set; }
        public string AreaTypeEnglishName { get; set; } = null!;
        public string AreaTypeArabicName { get; set; } = null!;
    }
}
