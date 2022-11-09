using System.ComponentModel.DataAnnotations;

namespace MyToDoAPI.Model.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
