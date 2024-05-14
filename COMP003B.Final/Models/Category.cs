using System.ComponentModel.DataAnnotations;

namespace COMP003B.Final.Models
{
    public class Category
    {
        public int categoryId { get; set; }

        [Required]
        public string categoryName {  get; set; }
    }
}
