using System.ComponentModel.DataAnnotations;

namespace COMP003B.Final.Models
{
    public class Product
    {

        public int productId { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public int ReleaseDate { get; set; }
        [Required]
        public int productQuantity { get; set; }
        [Required]
        public string Publisher { get; set; }  
        

        //Collection Navigation property
        public virtual ICollection<Product> GetProducts { get; set; }
       


    }
}
