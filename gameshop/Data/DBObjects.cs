using gameshop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Game.Any())
            {
                content.AddRange(
                     new Game
                     {
                         Name = "GTA V",
                         ShortDesc = "Open world game",
                         LongDesc = "Rockstar open world game",
                         Img = "/img/picture.jpg",
                         Price = 2000,
                         IsFavourite = true,
                         Avalible = true,
                         Category = Categories["Action"]
                     }
                    );
            }

            content.SaveChanges();
                
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[] {
                        new Category {CategoryName = "Action", Desc = "Игры жанра Action"},
                        new Category {CategoryName = "RPG", Desc = "Ролевые игры"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }
                return category;
            }
        }
    }
}
