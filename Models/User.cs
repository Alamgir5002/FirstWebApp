using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { set; get; } = 0;
        [Required(ErrorMessage = "User name cannot be null")]
        [MaxLength(50, ErrorMessage = "User name length should not exceed 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "User email cannot be null")]
        [MaxLength(30, ErrorMessage = "User email length should not exceed 30 characters")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "User password cannot be null")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password must contain length between 5-20 characters")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{6,}$", ErrorMessage = "Password must contain at least one uppercase letter and one numeric digit")]
        public string Password { get; set; }
    }
}
