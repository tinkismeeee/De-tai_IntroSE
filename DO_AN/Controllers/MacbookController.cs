using Microsoft.AspNetCore.Mvc;

namespace DO_AN.Controllers
{
    public class MacbookController : Controller
    {
        public IActionResult Macbook_Air_M4()
        {
            return View();
        }
        public IActionResult Macbook_Air()
        {
            return View();
        }
        public IActionResult Macbook_Pro_M4()
        {
            return View();
        }
    }
}
