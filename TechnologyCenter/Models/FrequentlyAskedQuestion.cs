using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class FrequentlyAskedQuestion
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string QuestionArabic { get; set; } = null!;
        public string QuestionEnglish { get; set; } = null!;
        public string AnswerArabic { get; set; } = null!;
        public string AnswerEnglish { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual QuestionGroup Group { get; set; } = null!;
    }
}
