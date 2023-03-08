using MockInterview.Domain.Entities.Users;

namespace MockInterview.Domain.Entities.Quizzes;

public class QuizResult
{
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }
    public int UserId { get; set; }
    public  User User { get; set; }
    public int CorrectAnswers { get; set; }
}