using MockInterview.Domain.Commons;

namespace MockInterview.Domain.Entities.Questions
{
    public class QuestionAnswer : Auditable
    {
        public string Content { get; set; }
        public Question QuestionId { get; set; }
        public bool IsTrue { get; set; }
    }
}
