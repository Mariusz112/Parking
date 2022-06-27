using System.ComponentModel.DataAnnotations;

namespace LibaryWeb.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Book { get; set; }
    }
}
