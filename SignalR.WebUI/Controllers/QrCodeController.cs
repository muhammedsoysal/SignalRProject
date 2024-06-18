using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace SignalR.WebUI.Controllers
{
    public class QrCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string value)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator codeGenerator = new QRCodeGenerator();
                QRCodeGenerator.QRCode squareCode = codeGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
                using (Bitmap bitmap = squareCode.GetGraphic(10))
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    ViewBag.qrCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();

        }
    }
}
