using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Service.Infrastructure;

namespace ShoppingCart.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategory _category;
        public CategoriesController(ICategory category)
        {
            _category = category;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var AllCategories = _category.GetAllCategories();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
