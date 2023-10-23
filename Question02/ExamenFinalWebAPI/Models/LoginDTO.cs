using System.ComponentModel.DataAnnotations;

namespace ExamenFinalWebAPI.Models
{
    public class LoginDTO
    {

        [Required]
        public String Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
