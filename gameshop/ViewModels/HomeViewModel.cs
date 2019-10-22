using gameshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> FavGames { get; set; }
    }
}
