using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos.BasketDtos;
using System.Text;

namespace SignalR.WebUI.Controllers
{
	public class BasketController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public BasketController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		[HttpGet]
		public async Task<IActionResult> Index(int tableNumber=4)

		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7009/api/Baskets/BasketListByMenuTableWithProductName{tableNumber}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData);
				return View(values);
			}
			return View();
		}
        public async Task<IActionResult> DeleteBasket(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7009/api/Baskets/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
			return NoContent();
        }
    }
}
