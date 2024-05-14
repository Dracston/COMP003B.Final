using System.ComponentModel.DataAnnotations;

namespace COMP003B.Final.Models
{
    public class Customer
    {
        public int customerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
