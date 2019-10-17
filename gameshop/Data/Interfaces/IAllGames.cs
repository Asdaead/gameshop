using gameshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Interfaces
{
    interface IAllGames
    {
        IEnumerable<Game> Games { get; }
        IEnumerable<Game> getFavGames { get; set; }
        Game getObjectGame(int gameid);
    }
}
