using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.web.Data
{
    public class Employee : IdentityUser
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string taxId { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime dateJoined { get; set;}


    }
}
