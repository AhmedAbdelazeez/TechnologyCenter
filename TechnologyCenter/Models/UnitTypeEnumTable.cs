using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class UnitTypeEnumTable
    {
        public int Id { get; set; }
        public int UnitTypeReference { get; set; }
        public string UnitTypeEnglishName { get; set; } = null!;
        public string UnitTypeArabicName { get; set; } = null!;
    }
}
