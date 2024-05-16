using System.ComponentModel.DataAnnotations;

namespace COMP003B.Final.Models
{
    public class Order
    {

        [Key] public int orderId { get; set; }
        public int customerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime orderDate { get; set; } = DateTime.Now;

       
    }
}
