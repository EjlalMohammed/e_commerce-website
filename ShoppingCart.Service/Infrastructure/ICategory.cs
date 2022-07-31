using shoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart.Service.Infrastructure
{
    public interface ICategory
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
        void save();




    }
}





