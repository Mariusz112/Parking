
using System.ComponentModel.DataAnnotations;

namespace LibaryWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Id")]
        public int DisplayOrder { get; set; }
    }
}
