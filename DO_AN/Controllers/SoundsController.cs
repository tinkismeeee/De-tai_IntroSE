using Microsoft.AspNetCore.Mvc;

namespace DO_AN.Controllers
{
    public class SoundsController : Controller
    {
        // GET: /Sounds/
        // Hành động này sẽ trả về View cho trang Âm thanh
        public IActionResult Index()
        {
            return View();
        }
    }
}
