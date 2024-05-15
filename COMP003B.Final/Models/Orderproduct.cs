namespace COMP003B.Final.Models
{
    public class Orderproduct
    {
        public int orderProductId { get; set; }
        public int productId { get; set; }
        public int orderId { get; set; }

        public string orderProductStatus { get; set; }
    }
}
