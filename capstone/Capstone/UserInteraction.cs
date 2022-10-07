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
            Console.WriteLine("\nPlease use the number pad to select an option below.\n");
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
        public static void PurchaseMenu(Purchase purchase)
        {
            Console.WriteLine("Please use the number pad to select an option below.\n");
            Console.WriteLine($"Current Money Provided: {purchase.Balance:c2}\n" + //need to fix reference to balance object
                "\n" +
                "(1) Feed Money\n" +
                "(2) Select Product\n" +
                "(3) Finish Transaction\n"); 
        }
        // feed money
        public static void UserFeedMoney(Purchase purchase)
        {
            Console.WriteLine("Please enter whole dollars.");
            Console.WriteLine(purchase.FeedMoney(Console.ReadLine()));
        }

        // finish transaction method
        public void UserSelectProduct(Inventory inventory, Purchase purchase)
        {
            DisplayItems(inventory);
            Console.Write("\nEnter Slot ID: ");
            //TODO! FIX THIS!!!!!
            //Console.WriteLine($"{Inventory.SelectProduct(Console.ReadLine())}");
            string slotId = Console.ReadLine();
            Item currentSelection = inventory.SelectProduct(slotId.ToUpper());

            if (currentSelection == null|| inventory.CheckItemExist(slotId.ToUpper(), currentSelection) == false)
            {
                Console.WriteLine("Error: Item matching that slot ID does not exist");
                return;
            }
            if (!inventory.CheckItemInStock(currentSelection))
            {
                Console.WriteLine("Error: Item out of stock");
                return;
            }
            

            //we have the product we want
            //TODO: Link to purchase check balance method            
            purchase.SelectProductToPurchase(currentSelection, purchase);

            //TODO: Link to purchase buy item method


            //update item count
            inventory.Dispense(currentSelection, purchase);
            //display message based on item type
            Console.WriteLine(currentSelection.Message);
        }

        public static void FinishTransaction(Purchase purchase)
        {
        
            Console.WriteLine(purchase.FinishTransaction());
            PurchaseMenu(purchase);

        }

        public static void BadInputErrorMessage()
        {
            Console.WriteLine("Invalid entry. Please enter 1, 2, or 3./n");
        }
        // hidden sales report method

        //Exit method

    }
}
