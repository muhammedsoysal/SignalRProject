using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
    public class FeaturController : Controller
    {
        IHttpClientFactory _httpClientFactory;

        public FeaturController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
