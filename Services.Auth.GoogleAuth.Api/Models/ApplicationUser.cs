using Microsoft.AspNetCore.Identity;

namespace Services.Auth.GoogleAuth.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? TwoFactorSecret { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public DateTime CreatedTime {  get; set; }
    }
}
