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

        // update count of inventory
        //public int UpdateCount()
        //{

        //}
        //Select product
        public string SelectProduct(string slotId)
        {
            return "";
            string selectedProduct;
            //Item currentSelection = InventoryList.FirstOrDefault().Where(i => i.SlotId = slot);
            foreach (Item item in InventoryList)
            {
                if (item.SlotId == slotId)
                {
                    selectedProduct = item.SlotId;
                }
            }
            //Cycle through list
            //{
            //if (item.slotId = slotid && item.count > 0)
            //{
            //we have the product we want

            //display message based on item type
            //update item count
            //balance = balance - price
            //go back
            //}

            //else if(item slotId == slotId)
            //{
            //return SoldOutError;
            //}
        //}
        //return badIdError;



            //



        }


        // selection encompases multiple functions
    }
}
