using shoppingCart.Domain.Models;
using ShoppingCart.Service.Data;
using ShoppingCart.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Repository
{

    public class CategoryRepo : ICategory
    {
        AppDbContext _context;

        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }

        
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);                                                                                                                                          
        }

        public void DeleteCategory(Category category)
        {
           _context.Categories.Remove(category);
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
