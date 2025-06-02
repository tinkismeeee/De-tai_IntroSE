using Microsoft.AspNetCore.Mvc;
using DO_AN.Models; 
using System.Collections.Generic;
using System.Linq;

namespace DO_AN.Controllers
{

    public class AccessoryController : Controller
    {
        // Đổi tên và kiểu của danh sách
        private static List<Accessory> _accessoryList = new List<Accessory>
        {
            // Cập nhật tên thuộc tính cho dữ liệu mẫu
            new Accessory { Id = 1, Name = "Bàn phím cơ Gaming Pro X RGB", Brand = "BrandX", Type = "Keyboard", Price = 1200000, Description = "Bàn phím cơ siêu bền, đèn RGB tùy chỉnh, switch Blue cho cảm giác gõ tốt nhất.", StockQuantity = 10, ImageUrl="https://placehold.co/600x400/E6E6FA/333?text=Keyboard+Pro" },
    new Accessory { Id = 2, Name = "Chuột không dây SilentClick Ergonomic", Brand = "BrandY", Type = "Mouse", Price = 750000, Description = "Chuột không gây tiếng ồn, thiết kế công thái học, pin sử dụng lên đến 3 tháng.", StockQuantity = 15, ImageUrl="https://placehold.co/600x400/F0E68C/333?text=ErgoMouse" },
    new Accessory { Id = 3, Name = "Tai nghe Bluetooth BassBoost Pro", Brand = "BrandZ", Type = "Headphones", Price = 990000, Description = "Tai nghe cho âm bass mạnh mẽ, chống ồn chủ động, thời lượng pin 20 giờ.", StockQuantity = 5, ImageUrl="https://placehold.co/600x400/ADD8E6/333?text=Headphones" }
        };
        private static int _nextId = 4;


        public IActionResult Index()
        {
            return View(_accessoryList); // Truyền danh sách _accessoryList
        }

        // GET: /Accessory/Details/1
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accessory = _accessoryList.FirstOrDefault(p => p.Id == id); // Tìm trong _accessoryList
            if (accessory == null)
            {
                return NotFound();
            }

            return View(accessory);
        }

        // GET: /Accessory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Accessory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Đảm bảo rằng các thuộc tính trong [Bind] khớp với tên thuộc tính mới trong Model Accessory
        public IActionResult Create([Bind("Name,Brand,Type,Price,Description,ImageUrl,StockQuantity")] Accessory accessory)
        {
            if (ModelState.IsValid)
            {
                accessory.Id = _nextId++;
                _accessoryList.Add(accessory);
                return RedirectToAction(nameof(Index));
            }
            return View(accessory);
        }
    }
}