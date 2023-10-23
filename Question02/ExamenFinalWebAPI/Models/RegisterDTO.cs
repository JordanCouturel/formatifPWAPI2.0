using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ExamenFinalWebAPI.Models
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirm { get; set; }

    }
}
