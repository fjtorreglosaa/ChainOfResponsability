using Microsoft.AspNetCore.Identity;

namespace ChainOfResponsability.Infrastructure.Contexts.Identity
{
    public class User : IdentityUser
    {
        public Guid UserId { get; set; }
        public Guid Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
