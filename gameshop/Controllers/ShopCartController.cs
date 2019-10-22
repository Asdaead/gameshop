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
    public class ShopCartController : Controller
    {
        private readonly IAllGames _gameRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllGames gameRep, ShopCart shopCart)
        {
            _gameRep = gameRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _gameRep.Games.FirstOrDefault(i => i.ID == id);

            if (item != null)
                _shopCart.AddToCart(item);
            
            return RedirectToAction("index");
        }
    }
}
