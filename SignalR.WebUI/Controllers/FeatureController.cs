using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
    public class FeatureController : Controller
    {
        IHttpClientFactory _httpClientFactory;

        public FeatureController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
