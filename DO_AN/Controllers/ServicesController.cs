using Microsoft.AspNetCore.Mvc;

namespace DO_AN.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult authorized_warranty()
        {
            return View();
        }

        public IActionResult services_packages()
        {
            return View();
        }

        public IActionResult authorized_services_fix(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            // Trả về view trong Views/Services/services_fix/{id}.cshtml
            return View($"authorized_services_fix/{id}");
        }

        public IActionResult services_packages_page(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            return View($"services_packages_page/{id}");
        }

    }
}