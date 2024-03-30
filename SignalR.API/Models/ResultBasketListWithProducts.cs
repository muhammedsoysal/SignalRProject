using SignalR.EntityLayer.Entities;

namespace SignalR.API.Models
{
    public class ResultBasketListWithProducts
    {
        public int BasketId { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
    }
}
