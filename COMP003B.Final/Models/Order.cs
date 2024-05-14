using System.ComponentModel.DataAnnotations;

namespace COMP003B.Final.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public int customerId { get; set; }

        [Required]
        public string orderName { get; set; }

        [Required]
        public decimal orderPrice { get; set; }

       
    }
}
