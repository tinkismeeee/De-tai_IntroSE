using Microsoft.AspNetCore.Mvc;

namespace DO_AN.Controllers
{
    public class AccessoriesController : Controller
    {
        // GET: /Accessories/
        // Hành động này sẽ trả về View cho trang Phụ kiện
        public IActionResult Index()
        {
            return View();
        }
    }
}
