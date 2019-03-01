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
    }
}
