using MockInterview.Domain.Commons;
using MockInterview.Domain.Enums;

namespace MockInterview.Domain.Entities.NewFolder
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone_Number { get; set; }
        public Role Role { get; set; }
        public Degree Degree { get; set; }
    }
}
