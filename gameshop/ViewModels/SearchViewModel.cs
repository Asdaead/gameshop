using gameshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<Game> allGames { get; set; }

        public string SearchString { get; set; }
    }
}
