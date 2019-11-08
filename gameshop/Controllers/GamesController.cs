using gameshop.Data.Interfaces;
using gameshop.Data.Models;
using gameshop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Controllers
{
    public class GamesController: Controller
    {
        private readonly IAllGames _allGames;
        private readonly IGamesCategory _allCategories;

        public GamesController(IAllGames iAllGames, IGamesCategory iGamesCat)
        {
            _allGames = iAllGames;
            _allCategories = iGamesCat;
        }

        [Route("Games/List")]
        [Route("Games/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Game> games = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
                games = _allGames.Games.OrderBy(i => i.ID);
             else
                if (string.Equals("RPG", category, StringComparison.OrdinalIgnoreCase)) 
                games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("RPG")).OrderBy(i => i.ID);
            else
                games = _allGames.Games.Where(i => i.Category.CategoryName.Equals("Action")).OrderBy(i => i.ID);

            currCategory = _category;

            var gameObj = new GamesListViewModel
            {
                allGames = games,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с играми";
   
            return View(gameObj);
        }

        public ViewResult Search (string id)
        {
            IEnumerable<Game> games = null;
            if (string.IsNullOrEmpty(id))
                games = _allGames.Games.OrderBy(i => i.ID);
            else
                games = _allGames.Games.Where(i => i.Name.Contains(id));
           
            var gameObj = new SearchViewModel
            {
                allGames = games,
                SearchString = id
            };

            return View(gameObj);

        }
    }
}
