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
        public string FeedMoney(string dollars)
        {
            
            int wholeDollars = 0;
            try
            {
                wholeDollars = int.Parse(dollars);               
                Balance += wholeDollars;
                return $"Money fed: {wholeDollars}";
            }
            catch (FormatException ex)
            {
               return ex.Message;
                
            }
        }
            public string FinishTransaction()
        {
            decimal cents = Balance * 100;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;

            while (cents >= 25)
            {
                quarters++;
                cents = cents - 25;
            }
            while (cents>= 10)
            {
                dimes++;
                cents = cents - 10;
            }
            while (cents >= 5)
            {
                nickels++;
                cents = cents - 5;
            }

            Balance = 0.00M;
            return $"{quarters} quarter(s), {dimes} dime(s), {nickels} nickel(s) returned./n Balance is now $0.00";
        }

            // update balance method

            // is it affordable? method

            // buy this item method

        }
}
