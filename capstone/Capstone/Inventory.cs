using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Capstone.Objects;
namespace Capstone
{
    public class Inventory
    {
        // get inventory from csv file
        public List<Item> InventoryList { get; set; } = new List<Item>();
        public Inventory()
        { }
        public void GetInventory()
        {
            string fileName = "vendingmachine.csv";
            string directory = Environment.CurrentDirectory;
            string fullPath = Path.Combine(directory, fileName);
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        List<string> parameters = line.Split('|').ToList();
                        Item newItem = new Item(parameters[0], parameters[1], decimal.Parse(parameters[2]), parameters[3]);
                        InventoryList.Add(newItem);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Trouble opening CSV file");
                Console.WriteLine(e.Message);
                throw;
            }
        }

        // soldout method: tells us whether item is sold out
        // does it exist?
        public bool CheckItemExist(string slotId, Item currentSelection)
        {
            bool doesExist = false;
            if (currentSelection.SlotId == slotId)
            {
                doesExist = true;
            }
            return doesExist;
        }
        public bool CheckItemInStock(Item currentSelection)
        {
            bool inStock = false;
            if (currentSelection.Count > 0)
            {
                inStock = true;
            }
            return inStock;

        }
        //Select product, encompases multiple subfunctions

        public string SelectProduct(string slotId)
        {
            string selectionMessage = "";
            //Cycle through list and matches the first item in list that has Item.SlotId == slotId parameter. defaults to first item in list if failure
            Item currentSelection = InventoryList.FirstOrDefault(i => i.SlotId == slotId);

            //Is our item in stock? Is our item actually the right item? 
            if (CheckItemExist(slotId, currentSelection) == false)
            {
                return "Error: Item matching that slot ID does not exist";//TODO: MAKE A MESSAGE FOR ITEM NOT EXISTING!
            }
            if (CheckItemInStock(currentSelection))
            { 
                return "Error: Item out of stock";//TODO: MAKE A MESSAGE FOR ITEM NOT EXISTING!
            }
            //we have the product we want

            //display message based on item type
            //update item count
            Dispense(currentSelection);
            //balance = balance - price
            return currentSelection.Message;
         }

        // update count of inventory
        public void Dispense(Item currentSelection)
         {
            currentSelection.Count--;
         }
    }
}
