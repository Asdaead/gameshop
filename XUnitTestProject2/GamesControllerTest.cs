using gameshop.Controllers;
using gameshop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using gameshop.Data.Repository;

namespace XUnitTestProject2
{
    public class GamesControllerTest
    {

        [Fact]
        public void Test1()
        {
            var mockGames = new Mock<GameRepository>();
            var mockCat = new Mock<CategoryRepository>();
            mockGames.Setup(repo => repo.Games).Returns(GetTestGames());
            mockCat.Setup(repo => repo.AllCategories).Returns(GetTestCategories());

            GamesController controller = new GamesController(mockGames.Object, mockCat.Object);


            ViewResult result = controller.Search("Divinity");
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Game>>(viewResult.Model);

            Assert.NotNull(result);
        }
        private List<Game> GetTestGames()
        {
            var games = new List<Game>
            {
                new Game { ID=1, Name="Divinity 2 Original Sin", CategoryID = 1}
            };
            return games;
        }
        private List<Category> GetTestCategories()
        {
            var categories = new List<Category>
            {
                new Category {CategoryName = "RPG", ID = 1}
            };
            return categories;
        }
    }
}
