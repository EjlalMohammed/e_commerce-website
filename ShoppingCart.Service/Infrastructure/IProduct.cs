using shoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Infrastructure
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product category);
        void UpdateProduct(Product category);
        void DeleteProduct(int id);
        void save();

    }
}
