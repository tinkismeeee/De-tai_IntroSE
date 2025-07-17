using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DO_AN.Models;
using DO_AN.Models.SQL_Server;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;
using Microsoft.Identity.Client;

namespace DO_AN.Controllers;

public class HomeController : Controller
{
    public readonly ILogger<HomeController> _logger;
    private readonly IntroSeDatabaseContext _context;
    private readonly PasswordHasher<UserInfo> _passwordHasher;

    public HomeController(ILogger<HomeController> logger, IntroSeDatabaseContext context)
    {
        _logger = logger;
        _context = context;
        _passwordHasher = new PasswordHasher<UserInfo>();
    }

    public IActionResult Index()
    {
        return View();
    }
    // Iphone
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult iphone_page_2()
    {
        return View();
    }
    //
    public IActionResult Sell_Equipment()
    {
        return View();
    }

    public IActionResult Cart()
    {
        return View();
    }
    public IActionResult Pay()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(string magioithieu1, string name, string gender, string day, string month, string year, string email, string phone, string username, string password, string repassword)
    {
        //if (ModelState.IsValid == false)
        //{
        //    Console.Write(false);
        //    return View();
        //}
        if (_context.UserInfos.Any(u => u.Username == username) && username != null)
        {
            bool username_exist = true;
            ViewBag.username_exist = username_exist;
            return View();
        }
        if (password == repassword && password != null)
        {
            TempData["message1"] = "message1";
            Console.WriteLine(magioithieu1 + " " + name + " " + gender + " " + day + " " + month + " " + year + " " + email + " " + phone + " " + username + " " + password);
            string[] gender_lable = {
                "Giới tính",
                "Male (Nam)",
                "Female (Nữ)",
                "Agender",
                "Abimegender",
                "Adamas gender",
                "Aerogender",
                "Aesthetigender",
                "Affectugender",
                "Agenderflux",
                "Alexigender",
                "Aliusgender",
                "Amaregender",
                "Ambigender",
                "Ambonec",
                "Amicagender",
                "Androgyne",
                "Anesigender",
                "Angenital",
                "Anogender",
                "Anongender",
                "Antegender",
                "Anxiegender",
                "Apagender",
                "Apconsugender",
                "Astergender",
                "Astral gender",
                "Autigender",
                "Autogender",
                "Axigender",
                "Bigender",
                "Biogender",
                "Blurgender",
                "Boyflux",
                "Burstgender",
                "Caelgender",
                "Cassgender",
                "Cassflux",
                "Cavusgender",
                "Cendgender",
                "Ceterogender",
                "Ceterofluid",
                "Cisgender",
                "Cloudgender",
                "Collgender",
                "Colorgender",
                "Commogender",
                "Condigender",
                "Deliciagender",
                "Demifluid",
                "Demiflux",
                "Demigender",
                "Domgender",
                "Duragender",
                "Egogender",
                "Epicene",
                "Esspigender",
                "Exgender",
                "Existigender",
                "Femfluid",
                "Femgender",
                "Fluidflux",
                "Gemigender",
                "Genderblank",
                "Genderflow",
                "Genderfluid",
                "Genderfuzz",
                "Genderflux",
                "Genderpuck",
                "Genderqueer",
                "Gender witched",
                "Girlflux",
                "Healgender",
                "Mirrorgender",
                "Omnigender"
            };
            if ((gender == "0" || day == "0" || month == "0" || year == "0") && name != null)
            {
                bool gender_err = true;
                ViewBag.gender_err = gender_err;
                return View();
            }
            var user = new UserInfo
            {
                Magioithieu1 = magioithieu1,
                Name = name,
                Gender = gender_lable[int.Parse(gender)],
                Day = day,
                Month = month,
                Year = year,
                Email = email,
                Phone = phone,
                Username = username,
                Password = _passwordHasher.HashPassword(null, password)
            };
            _context.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
        return View();
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string tendangnhap, string nhapmatkhau)
    {
        var user = _context.UserInfos.FirstOrDefault(u => u.Username == tendangnhap);
        if (user != null)
        {
            Console.WriteLine("True");
            string get_password = user.Password;
            var result = _passwordHasher.VerifyHashedPassword(null, get_password, nhapmatkhau);
            if (result == PasswordVerificationResult.Success)
            {
                return RedirectToAction("", "Home");
            }
            else
            {
                bool saimk = true;
                ViewBag.saimk = saimk;
                return View();
            }
        }
        else
        {
            Console.WriteLine("False");
        }
        return View();
    }
    public IActionResult PayProduct()
    {
        return View();
    }
    public IActionResult Home_page()
    {
        return View();
    }
    public IActionResult iPad()
    {
        return View();
    }
    public IActionResult Watch()
    {
        return View();
    }
    public IActionResult Macbook()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

