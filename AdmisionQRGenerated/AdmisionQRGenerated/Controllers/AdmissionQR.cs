using AdmisionQRGenerated.Models;
using IronBarCode;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdmisionQRGenerated.Controllers
{
    public class AdmissionQR : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public AdmissionQR(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateQr(Admissionlist al)
        {
            string jsonText = JsonConvert.SerializeObject(al);

            GeneratedBarcode barcode = QRCodeWriter.CreateQrCode(jsonText, 200);
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.SetMargins(10);
            barcode.ChangeBarCodeColor(Color.Black);
            string path = Path.Combine(_environment.WebRootPath, "q");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = Path.Combine(_environment.WebRootPath, "q/qrcode.png");
            barcode.SaveAsPng(filePath);
            string fileName = Path.GetFileName(filePath);
            string imageUrl = $"{this.Request.Scheme}://" + $"{this.Request.Host}{this.Request.PathBase}" + "/q/" + fileName;
            ViewBag.QrCodeUri = imageUrl;
            return View();
        }
    }
}
