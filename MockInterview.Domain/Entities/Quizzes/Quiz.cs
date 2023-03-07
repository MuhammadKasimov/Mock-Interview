using MockInterview.Domain.Commons;
using MockInterview.Domain.Entities.Questions;
using System;
using System.Collections.Generic;

namespace MockInterview.Domain.Entities.Quizzes
{
    public class Quiz : Auditable
    {
        public int Count { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
