using Microsoft.EntityFrameworkCore;
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
    public class ProductRepo : IProduct
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        } 
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);                                                                                                                 
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include(c=>c.Categories).ThenInclude(y=>y.Category).Where(x => x.Id == id).FirstOrDefault();
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
