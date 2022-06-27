
using System.ComponentModel.DataAnnotations;

namespace LibaryWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Release_Date { get; set; }
        public string Author { get; set; }

    }
}
