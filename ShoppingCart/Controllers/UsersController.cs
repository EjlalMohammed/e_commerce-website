using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
