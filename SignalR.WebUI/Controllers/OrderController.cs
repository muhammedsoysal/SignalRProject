using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
