using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required] //validation
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage="Password must be between 4 and 8 characters")] //maximun string lentgh allowed = 8
        public string Password { get; set; }
    }
}