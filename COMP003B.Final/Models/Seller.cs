using System.ComponentModel.DataAnnotations;

namespace COMP003B.Final.Models
{
    public class Seller
    {

        public int sellerId { get; set; }

        [Required]
        public string sellerName { get; set;}
        [Required]
        public decimal shippingPrice { get; set; }

    }
}
