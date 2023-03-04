using MockInterview.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Domain.Entities.Questions
{
    public class QuestionAnswer : Auditable
    {
        public string Content { get; set; }
        public Question QuestionId { get; set; }
        public bool IsTrue { get; set; }
    }
}
