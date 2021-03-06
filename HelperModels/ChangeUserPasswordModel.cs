using System.ComponentModel.DataAnnotations;

namespace API_Users.Models
{
    public class ChangeUserPasswordModel
    {
        public string Id { get; set; }
        [MaxLength(255), EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string OldPassword { get; set; }
        [Required, MinLength(4)]
        public string NewPassword { get; set; }
    }
}