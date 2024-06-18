using SignalR.EntityLayer.Entities;

namespace SignalR.WebUI.Dtos.BasketDtos
{
	public class ResultBasketDto
	{
		public int BasketId { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string ProductName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public decimal Price { get; set; }
		public int Count { get; set; }
		public decimal TotalPrice { get; set; }
		public int ProductId { get; set; }
		public int MenuTableId { get; set; }
	}
}
