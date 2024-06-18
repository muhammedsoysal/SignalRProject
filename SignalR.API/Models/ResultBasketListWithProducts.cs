using SignalR.EntityLayer.Entities;

namespace SignalR.API.Models
{
    public class ResultBasketListWithProducts
    {
        public int BasketId { get; set; }
        public decimal Price { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string ProductName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
    }
}
