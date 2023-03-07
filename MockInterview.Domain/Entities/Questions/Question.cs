using MockInterview.Domain.Commons;
using MockInterview.Domain.Entities.Quizzes;
using System.Collections.Generic;

namespace MockInterview.Domain.Entities.Questions
{
    public class Question : Auditable
    {
        public string Content { get; set; }
        public Quiz QuizId { get; set; }

        public virtual ICollection<QuestionAnswer> Answers { get; set; }
    }
}
