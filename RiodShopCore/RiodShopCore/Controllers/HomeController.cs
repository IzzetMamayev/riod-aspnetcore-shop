using Microsoft.AspNetCore.Mvc;

namespace RiodShopCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
