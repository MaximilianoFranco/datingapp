using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        //puting "Required" fields here instead of using Required in our "Entity" directly allow us to avoid depending on details (database on this case)
        
        [Required]
        public string Username {get; set;}

        [Required]
        [StringLength(16, MinimumLength = 8)]
        public string Password {get; set;}
    }
}