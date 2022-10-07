
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Objects;
using System.Collections.Generic;

namespace CapstoneTests
{
    [TestClass]
    public class PurchaseTest
    {
        [TestMethod]
       public void FeedMoneyTest()
        {
            Purchase purchase = new Purchase();

            string firstInput = "5";

            string actualResult = purchase.FeedMoney(firstInput, new List<string>());
            int result = 5;
            string expectedResult =$"Money fed: {result:c2}";

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        
        public void FinishTransactionTest()
        {
            Purchase purchase = new Purchase();

            purchase.FeedMoney("1", new List<string>());
            string actualResult = purchase.FinishTransaction(new List<string>());

            string expectedResult = $"$1.00 dispensed. 4 quarter(s), 0 dime(s), 0 nickel(s) returned.\nBalance is now $0.00";

            Assert.AreEqual(expectedResult, actualResult);

            decimal expectedResultBalance = 0.00M;

            decimal actualResultBalance = purchase.Balance;
            
            Assert.AreEqual(expectedResultBalance, actualResultBalance);

        }
        [TestMethod]

        public void SelectProductToPurchaseTest()
        {
            Purchase purchase = new Purchase();
            Item item = new Item("A3", "chips", 5.00M, "chip");
            purchase.FeedMoney("5", new List<string>());
            string expectedResult = "";
            string actualResult = purchase.SelectProductToPurchase(item, purchase, new List<string>());
            Assert.AreEqual(expectedResult, actualResult);

            
            
            Item item1 = new Item("A3", "chips", 5.00M, "chip");
            purchase.FeedMoney("2", new List<string>());
            string expectedResult1 = "Balance Insufficient for purchase.";
            string actualResult1 = purchase.SelectProductToPurchase(item1, purchase, new List<string>());
            Assert.AreEqual(expectedResult1, actualResult1);



        }


        [TestMethod]

        public void CheckBalanceForItemTest()
        {
            Purchase purchase = new Purchase();
            Item item = new Item("A3",  "chips", 5.00M, "chip");
           
            bool expectedResult = false;
            
            bool actualResult = purchase.CheckBalanceForItem(item);
            Assert.AreEqual(expectedResult, actualResult);

            Item item1 = new Item("A3", "chips", 5.00M, "chip");
            purchase.FeedMoney("5", new List<string>());

            bool expectedResult1 = true;

            bool actualResult1 = purchase.CheckBalanceForItem(item);
            Assert.AreEqual(expectedResult1, actualResult1);
        }
    }
}
