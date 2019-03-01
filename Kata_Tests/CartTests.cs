using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrocerKata;

namespace Kata_Tests
{
    [TestClass]
    public class CartTests
    {
        Cart testCart;

        [TestInitialize]
        public void TestSetup()
        {
            testCart = new Cart();
        }

        [TestMethod]
        public void AddItemToCart()
        {
            testCart.AddItem("apple");
            Assert.AreEqual(1, testCart.Items["apple"]);
        }

        [TestMethod]
        public void AddItemsToCart()
        {
            testCart.AddItem("apple");
            testCart.AddItem("apple");
            Assert.AreEqual(2, testCart.Items["apple"]);
        }

        [TestMethod]
        public void AddItemToCartWithWeight()
        {
            decimal weight = 1.24m;
            testCart.AddItem("hamburger", weight);
            Assert.AreEqual(1.24m, testCart.Items["hamburger"]);
        }

        [TestMethod]
        public void AddItemsToCartWithWeight()
        {
            decimal weight = 1.24m;
            testCart.AddItem("hamburger", weight);
            testCart.AddItem("hamburger", weight);
            Assert.AreEqual(2.48m, testCart.Items["hamburger"]);
        }

        [TestMethod]
        public void RemoveItemFromCart()
        {
            testCart.AddItem("apple");
            testCart.RemoveItem("apple");
            Assert.AreEqual(0, testCart.Items["apple"]);

        }
    }
}
