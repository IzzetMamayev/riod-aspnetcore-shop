using Microsoft.AspNetCore.Mvc;

namespace RiodShopCore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult WishList()
        {
            return View();
        }
    }
}
