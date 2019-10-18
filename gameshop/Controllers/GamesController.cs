using gameshop.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Страница с играми";
            GamesListViewModel obj = new GamesListViewModel();
            obj.allGames = _allGames.Games;
            obj.currCategory = "Игры";

            return View(obj);
        }
    }
}
