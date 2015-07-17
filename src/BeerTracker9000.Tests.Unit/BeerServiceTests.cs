using System;
using BeerTracker9000.Models;
using BeerTracker9000.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeerTracker9000.Tests.Unit
{
    [TestClass]
    public class BeerServiceTests
    {
        [TestMethod]
        public void AddBeer_WithAValidBeer_AddsBeer()
        {
          var beerservice = new BeerService();
            var beer = new Beer
            {
                Name = "Goofball Beer",
                Type = BeerTypes.Saison,
                Brewery = "McPita's Brewery",
                Description = "made with the finest malts and barley",
                ABV = 7.5m
            };
            bool added = beerservice.AddBeer(beer);
            Assert.IsTrue(added);


        }
        [TestMethod]
        public void AddBeer_WithInvalidBeer_ReturnsFalse()
        {
            var beerservice = new BeerService();
            var beer = new Beer {Name = null};
            bool added = beerservice.AddBeer(beer);
            Assert.IsFalse(added);
        }
    }
}
