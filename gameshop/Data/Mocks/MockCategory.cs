using gameshop.Data.Interfaces;
using gameshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Mocks
{
    public class MockCategory : IGamesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Action", Desc = "Игры жанра Action"},
                    new Category {CategoryName = "RPG", Desc = "Ролевые игры"}
                };
            }
        }
    }
}
