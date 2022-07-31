using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Price { get; set; }
        public int Code { get; set; }

        public decimal DiscountPercentage { get; set; }

        public string? ProductImage { get; set; }

        public int CreateBy { get; set; }

        public DateTime CreateAt { get; set; }

        public ICollection<ProductsCategory> Categories { get; set; }



    }
}
