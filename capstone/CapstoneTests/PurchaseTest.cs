
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
