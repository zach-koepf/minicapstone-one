
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Objects;

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

            string actualResult = purchase.FeedMoney(firstInput);
            int result = 5;
            string expectedResult =$"Money fed: {result}";

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        
        public void FinishTransactionTest()
        {
            Purchase purchase = new Purchase();

            purchase.FeedMoney("1");
            string actualResult = purchase.FinishTransaction();

            string expectedResult = $"$1.00 dispensed. 4 quarter(s), 0 dime(s), 0 nickel(s) returned./n Balance is now $0.00";

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
            purchase.FeedMoney("5");
            string expectedResult = "Crunch Crunch, Yum!";
            string actualResult = purchase.SelectProductToPurchase(item, purchase);
            Assert.AreEqual(expectedResult, actualResult);

            
            
            Item item1 = new Item("A3", "chips", 5.00M, "chip");
            purchase.FeedMoney("2");
            string expectedResult1 = "Balance Insufficient for purchase.";
            string actualResult1 = purchase.SelectProductToPurchase(item1, purchase);
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
            purchase.FeedMoney("5");

            bool expectedResult1 = true;

            bool actualResult1 = purchase.CheckBalanceForItem(item);
            Assert.AreEqual(expectedResult1, actualResult1);
        }
    }
}
