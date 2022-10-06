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


        // selection encompases multiple functions
    }
}
