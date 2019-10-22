using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Models
{
    public class ShopCart
    {

            private readonly AppDBContent appDBContent;

            public ShopCart(AppDBContent appDBContent)
            {
                this.appDBContent = appDBContent;
            }

        public string ShopCartID { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services) 
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
           
            session.SetString("CartID", shopCartId);

            return new ShopCart(context) { ShopCartID = shopCartId };
        }

        public void AddToCart(Game game)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem {
                ShopCartId = ShopCartID,
                Game = game,
                Price = game.Price
           }) ;

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem
                .Where(c => c.ShopCartId == ShopCartID)
                .Include(s => s.Game).ToList();
        }
    }
}
