using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Objects;

namespace Capstone
{
    public class UserInteraction
    {
        // Display the main menu
        public static void DisplayMainMenu()
        {
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
        }
        
        // display items method
        public static void DisplayItems(Inventory inventory)
        {
            
            //List<Item> inventory = Inventory.GetInventory(); // need most recently updated inventory , call current status of existing items
            foreach (var item in inventory.InventoryList)
            {
                if (item.Count != 0)
                {
                    Console.WriteLine($"{item.SlotId} {item.Name} {item.Price:c2} remaining: {item.Count}");
                }
                else
                {
                    Console.WriteLine($"{item.SlotId} {item.Name} {item.Price:c2} remaining: SOLD OUT");
                }
                //   Console.WriteLine($"{inventory.}");
            }

        }

        // Purchase method
        public static void PurchaseMenu(Purchase balance)
        {
            Console.WriteLine($"Current Money Provided: {balance.Balance}/n" + //need to fix reference to balance object
                "/n" +
                "(1) Feed Money/n" +
                "(2) Select Product/n" +
                "(3) Finish Transaction"); 
        }
        // feed money
        public static void UserFeedMoney(Purchase purchase)
        {
            purchase.FeedMoney();
        }

        // finish transaction method

        public static void FinishTransaction(Purchase purchase)
        {
        
            Console.WriteLine(purchase.FinishTransaction());
            DisplayMainMenu();

        }

        public static void BadInputErrorMessage()
        {
            Console.WriteLine("Invalid entry. Please enter 1, 2, or 3./n");
        }
        // hidden sales report method

        //Exit method

    }
}
