using System.ComponentModel.DataAnnotations;

namespace MyToDoAPI.Model
{
    public class ToDos
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsDone { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        

    }
}
