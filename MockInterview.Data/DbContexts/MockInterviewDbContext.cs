using Microsoft.EntityFrameworkCore;
using MockInterview.Domain.Entities.Interviewers;
using MockInterview.Domain.Entities.Interviews;
using MockInterview.Domain.Entities.NewFolder;
using MockInterview.Domain.Entities.Questions;
using MockInterview.Domain.Entities.Quizzes;

namespace MockInterview.Data.DbContexts
{
    public class MockInterviewDbContext : DbContext
    {
        public MockInterviewDbContext(DbContextOptions<MockInterviewDbContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Interviewer> Interviewers { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Interviewer>();
            modelBuilder.Entity<Interview>();
            modelBuilder.Entity<Quiz>();
            modelBuilder.Entity<Question>();
            modelBuilder.Entity<QuestionAnswer>();
        }
    }
}
