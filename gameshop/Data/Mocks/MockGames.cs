using gameshop.Data.Interfaces;
using gameshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Mocks
{
    public class MockGames : IAllGames
    {
        private readonly IGamesCategory _categoryGames = new MockCategory();
        public IEnumerable<Game> Games
        {
            get
            {
                return new List<Game>
                {
                    new Game {Name = "GTA V",
                        ShortDesc = "Open world game",
                        LongDesc = "Rockstar open world game",
                        Img = "/img/picture.jpg" ,
                        Price = 2000,
                        IsFavourite = true,
                        Avalible = true ,
                        Category = _categoryGames.AllCategories.First()
                   }
                };
            }
        }
        public IEnumerable<Game> getFavGames { get; set; }

        public Game getObjectGame(int gameid)
        {
            throw new NotImplementedException();
        }
    }
}

