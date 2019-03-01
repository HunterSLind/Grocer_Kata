using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrocerKata;

namespace Kata_Tests
{
    [TestClass]
    public class PriceCalculatorTests
    {
        Cart cart;

        [TestInitialize]
        public void Setup()
        {
            cart = new Cart();
        }
        
        [TestMethod]
        public void PriceEmptyCart()
        {
            Assert.AreEqual(0.00m, PriceCalculator.CalculateCartPrice(cart));
        }

        [TestMethod]
        public void PriceCartWithItem()
        {
            cart.AddItem("hamburger", 1);
            Assert.AreEqual(5.99m, PriceCalculator.CalculateCartPrice(cart));
        }

        [TestMethod]
        public void PriceCartWithMarkdownItem()
        {
            cart.AddItem("apple");
            Assert.AreEqual(1.99m, PriceCalculator.CalculateCartPrice(cart));
        }

        [TestMethod]
        public void PriceCartWithSpecialItem()
        {
            cart.AddItem("banana");
            Assert.AreEqual(0.99m, PriceCalculator.CalculateCartPrice(cart));
        }

        [TestMethod]
        public void PriceCartWithWeightedItem()
        {
            cart.AddItem("hamburger", 1.23m); // this should cost 1.23*5.99= 7.3677 rounded up = 7.37
            Assert.AreEqual(7.37m, PriceCalculator.CalculateCartPrice(cart));
        }

        [TestMethod]
        public void PriceCartWithMoreThanSpecialLimit()
        {
            cart.AddItem("soup");
            cart.AddItem("soup");
            cart.AddItem("soup");
            cart.AddItem("soup");
            cart.AddItem("soup"); // 1.99 * 5 = 9.95;
            cart.AddItem("soup"); // 9.95 + 2.49 = 12.44
            Assert.AreEqual(12.44m, PriceCalculator.CalculateCartPrice(cart));
        }
    }
}
