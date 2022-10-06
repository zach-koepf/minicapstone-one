using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Purchase
    {
        // Price property?
        //public decimal Price { get; }
        // Balance property

        public decimal Balance { get; private set; } = 0;
        // Feed Money method
        public void FeedMoney()
        {
            Console.WriteLine($"Provide Money:");
            string dollars = Console.ReadLine();
            int wholeDollars = 0;
            try
            {
                wholeDollars = int.Parse(dollars);
                Console.WriteLine($"Money fed: {wholeDollars}");
                Balance += wholeDollars;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            // dispense change method

            // update balance method

            // is it affordable? method

            // buy this item method

        }
}
