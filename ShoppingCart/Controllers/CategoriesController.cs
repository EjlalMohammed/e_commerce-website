using Microsoft.AspNetCore.Mvc;
using shoppingCart.Domain.Models;
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
            return View(AllCategories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            try
            {
                _category.AddCategory(category);
                return RedirectToAction(nameof(Index)); 
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var categories = _category.GetCategoryById(id);
            return View(categories);
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
