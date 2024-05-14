using System.ComponentModel.DataAnnotations;

namespace COMP003B.Final.Models
{
    public class Product
    {

        public int productId { get; set; }

        [Required]
        public decimal productPrice { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public int productCode { get; set; }
        [Required]
        public int productQuantity { get; set; }
       


    }
}
