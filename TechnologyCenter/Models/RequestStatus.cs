using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class RequestStatus
    {
        public int Id { get; set; }
        public int RequestStatusReference { get; set; }
        public string RequestStatusArabicName { get; set; } = null!;
        public string RequestStatusEnglishName { get; set; } = null!;
    }
}
