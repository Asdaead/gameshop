using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Models
{
    public class Category
    {
        public int ID { set; get; }
        public string CategoryName { set; get; }
        public string Desc { set; get; }
        public List<Game> Games { set; get; }
    }
}
