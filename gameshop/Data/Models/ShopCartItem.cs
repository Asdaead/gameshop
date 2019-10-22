using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public int Price { get; set; }
        public string ShopCartId { get; set; }

    }
}
