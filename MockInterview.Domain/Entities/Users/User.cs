using MockInterview.Domain.Commons;
using MockInterview.Domain.Enums;

namespace MockInterview.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
        public Degree Degree { get; set; }
    }
}
