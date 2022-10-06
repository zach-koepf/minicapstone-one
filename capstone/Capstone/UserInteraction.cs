using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Objects;

namespace Capstone
{
    public class UserInteraction
    {
        // Display the main menu
        public void DisplayMainMenu()
        {
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
        }
        
        // display items method
        public void DisplayItems()
        {

            List<Item> inventory = Inventory.GetInventory(); // need most recently updated inventory , call current status of existing items
            foreach (var item in inventory)
            {
             //   Console.WriteLine($"{inventory.}");
            }

        }

        // Purchase method
        
        // finish transaction method

        // hidden sales report method

    }
}
