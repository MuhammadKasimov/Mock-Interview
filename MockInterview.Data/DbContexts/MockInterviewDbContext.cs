using Microsoft.EntityFrameworkCore;
using MockInterview.Domain.Entities.Interviews;
using MockInterview.Domain.Entities.Questions;
using MockInterview.Domain.Entities.Quizzes;
using MockInterview.Domain.Entities.Users;

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
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(u => u.PhoneNumber)
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
            
            modelBuilder.Entity<Interviewer>()
                .HasIndex(i => i.Email)
                .IsUnique();            
            modelBuilder.Entity<Interviewer>()
                .HasIndex(i => i.PhoneNumber)
                .IsUnique();            
            modelBuilder.Entity<Interviewer>()
                .HasIndex(i => i.Username)
                .IsUnique();
        }
    }
}
