using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class QuestionGroup
    {
        public QuestionGroup()
        {
            FrequentlyAskedQuestions = new HashSet<FrequentlyAskedQuestion>();
        }

        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual ICollection<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; }
    }
}
