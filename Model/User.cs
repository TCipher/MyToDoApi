using System.ComponentModel.DataAnnotations;

namespace MyToDoAPI.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

        public ICollection<ToDos> Todos { get; set; }
    }
}

