using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class SubUnitTypeEnumTable
    {
        public int Id { get; set; }
        public int SubUnitTypeReference { get; set; }
        public string SubUnitTypeEnglishName { get; set; } = null!;
        public string SubUnitTypeArabicName { get; set; } = null!;
        public int UnitTypeMainReference { get; set; }
    }
}
