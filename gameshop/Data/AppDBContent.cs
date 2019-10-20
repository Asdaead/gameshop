using gameshop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }

        public DbSet<Game> Game { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
