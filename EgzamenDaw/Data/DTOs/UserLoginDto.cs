using System.ComponentModel.DataAnnotations;

namespace EgzamenDaw.Data.DTOs
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
