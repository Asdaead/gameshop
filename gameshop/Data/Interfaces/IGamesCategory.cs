using gameshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Interfaces
{
   public interface IGamesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
