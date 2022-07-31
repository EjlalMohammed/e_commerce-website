using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string username { get; set; }
        public int type { get; set; }
        public string password { get; set; }
    }
}
