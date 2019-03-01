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

        [TestMethod]
        public void UpdateSpecialPrice()
        {
            decimal newSpecialPrice = 3.99m;
            priceMan.UpdateItemSpecialPrice("hamburger", newSpecialPrice);
            Assert.AreEqual(3.99m, FakeInventory.Inventory["hamburger"].SpecialPrice);
        }

        [TestMethod]
        public void UpdateMarkdownPrice()
        {
            decimal newMarkdownPrice = 1.99m;
            priceMan.UpdateItemMarkdownPrice("hamburger", newMarkdownPrice);
            Assert.AreEqual(1.99m, FakeInventory.Inventory["hamburger"].MarkDownPrice);
        }

        [TestMethod]
        public void UpdateSpecialLimit()
        {
            decimal newLimit = 1;
            priceMan.UpdateItemSpecialLimit("hamburger", newLimit);
            Assert.AreEqual(1, FakeInventory.Inventory["hamburger"].SpecialLimit);
        }
    }
}
