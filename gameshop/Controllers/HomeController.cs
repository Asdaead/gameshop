using gameshop.Data.Interfaces;
using gameshop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllGames _gameRep;
 

        public HomeController(IAllGames gameRep)
        {
            _gameRep = gameRep;

        }

        public ViewResult Index()
        {
            var homeGames = new HomeViewModel
            {
                FavGames = _gameRep.getFavGames
            };
            return View(homeGames);

        }
    }
}
