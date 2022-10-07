using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Objects;

namespace CapstoneTests
{
    [TestClass]
    public class InventoryTest
    {
     [TestMethod]

     public void CheckItemExistsTest()
        {
            Inventory inventory = new Inventory();
            Item item = new Item("A3", "chips", 5.00M, "chip");
            bool expectedResult = true;
            
            bool actualResult = inventory.CheckItemExist(item.SlotId, item);
            Assert.AreEqual(expectedResult, actualResult);



        }
        [TestMethod]

    public void CheckItemInStockTest()
        {
            Inventory inventory = new Inventory();
            Item item = new Item("A3", "chips", 5.00M, "chip");
            bool expectedResult = true;
            bool actualResult = inventory.CheckItemInStock(item);
            Assert.AreEqual(expectedResult, actualResult);
        }


  
    }
}
