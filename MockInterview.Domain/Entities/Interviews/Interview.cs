using MockInterview.Domain.Commons;
using MockInterview.Domain.Entities.Interviewers;
using MockInterview.Domain.Entities.NewFolder;
using System;

namespace MockInterview.Domain.Entities.Interviews
{
    public class Interview : Auditable
    {
        public int InterviewerId { get; set; }
        public Interviewer Interviewer { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime StartDate { get; set; }
    }
}
