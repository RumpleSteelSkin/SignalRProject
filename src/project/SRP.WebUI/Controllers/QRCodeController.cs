using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing.Imaging;

namespace SRP.WebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string value)
        {
            using (var memoryStream = new MemoryStream())
            {
                var createQrCode = new QRCodeGenerator();
                var squareCode = createQrCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
                using (var image = squareCode.GetGraphic(10))
                {
                    image.Save(memoryStream, ImageFormat.Png);
                    ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            return View();
        }
    }
}