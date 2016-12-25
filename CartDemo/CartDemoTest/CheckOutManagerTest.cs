using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CartDemoTest
{
    [TestClass]
    public class CheckOutManagerTest
    {
        private CartDemo.CheckOutManager checkoutManager;

        [TestInitialize()]
        public void Initialize()
        {
            //  TODO: Add test initialization code
            checkoutManager = new CartDemo.CheckOutManager();
        }


        [TestMethod]
        public void GetPriceForApplesWithBuyOneGetOneFreeOffer()
        {
            Assert.AreEqual(0.45, checkoutManager.CheckOut(new List<string> { "Apples" }));
            Assert.AreEqual(0.45, checkoutManager.CheckOut(new List<string> { "Apples", "Apples" }));
            Assert.AreEqual(0.9, checkoutManager.CheckOut(new List<string> { "Apples", "Apples", "Apples" }));
            Assert.AreEqual(1.1, checkoutManager.CheckOut(new List<string> { "Apples", "Apples", "Oranges"}));
            Assert.AreEqual(0, checkoutManager.CheckOut(new List<string> { "Grapes" }));

        }
    }
}
