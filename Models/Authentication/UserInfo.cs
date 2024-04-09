using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestoCommand.Models.Authentication
{
    public enum UserRoles
    {
        User,
        Admin
    }

    public class UserInfo
    {
        public string Id { get; set; } = string.Empty;

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [PasswordPropertyText(true)]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        [MaxLength(20, ErrorMessage = "Password must be at most 20 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,20}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one digit")]
        public string Password { get; set; } = string.Empty;

        public UserRoles Role { get; set; } = UserRoles.User;
    }
}
