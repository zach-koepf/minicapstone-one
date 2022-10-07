using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Objects;
using System.IO;

namespace Capstone
{
    public class SalesReporting
    {

        public static void SalesReport (Inventory inventory)
        {
            string directory = Environment.CurrentDirectory + @"\..\..\..\..\";
            string fileName = "SalesReport.CSV";
            string fullPath = Path.Combine(directory, fileName);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                decimal revenue = 0;
                foreach(Item item in inventory.InventoryList)
                {
                    sw.WriteLine($"{item.Name}|{5 - item.Count}");
                    revenue += (item.Price * (5 - item.Count));
                }
                sw.WriteLine($"\n** TOTAL SALES ** {revenue:c2}");
            }
        }
    }
}
