using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrocerKata;

namespace Kata_Tests
{
    [TestClass]
    public class PriceManagerTests
    {
        PriceManager priceMan;

        [TestInitialize]
        public void TestSetup()
        {
            priceMan = new PriceManager();
        }

        [TestMethod]
        public void UpdateItemPrice()
        {
            decimal newPrice = 6.99m;
            priceMan.UpdateItemPrice("hamburger", newPrice);
            Assert.AreEqual(6.99m, FakeInventory.Inventory["hamburger"].PricePerUnit);
        }
    }
}
