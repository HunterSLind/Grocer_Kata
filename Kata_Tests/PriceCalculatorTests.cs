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
    }
}
