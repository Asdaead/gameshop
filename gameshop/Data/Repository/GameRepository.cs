using gameshop.Data.Interfaces;
using gameshop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Repository
{
    public class GameRepository : IAllGames
    {
        private readonly AppDBContent appDBContent;
        
        public GameRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Game> Games => appDBContent.Game.Include(c => c.Category);

        public IEnumerable<Game> getFavGames => appDBContent.Game.Where(p => p.IsFavourite).Include(c => c.Category);

        public Game getObjectGame(int gameid) => appDBContent.Game.FirstOrDefault(p => p.ID == gameid);
        
    }
}
