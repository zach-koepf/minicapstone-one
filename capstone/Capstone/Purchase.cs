using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Objects;

namespace Capstone
{
    public class Purchase
    {
        // Price property?
        //public decimal Price { get; }
        // Balance property
        public List<string> TransactionLog { get; set; } = new List<string>();
        public decimal Balance { get; private set; } = 0;

        // Feed Money method
        public string FeedMoney(string dollars, List<string> transactionLog)
        {
            int wholeDollars = 0;
            try
            {
                wholeDollars = int.Parse(dollars);
                if (wholeDollars >= 0)
                {
                    Balance += wholeDollars;
                    transactionLog.Add($"{DateTime.Now} FEED MONEY: ${wholeDollars}.00 ${Balance}.00");
                    return $"Money fed: ${wholeDollars}.00";
                }
                else
                    return "Please provide whole dollars (positive integer).";
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please provide whole dollars (integers)");
                return ex.Message;
            }
        }
        // select product method (string slotID & Purchase purchase)
        //need method to call in inventory select product method. method here solely deals with money transaction? & logging
        public bool CheckBalanceForItem(Item currentSelection)
        {
            // get current balance
            // if balance >= item.price
            if (Balance >= currentSelection.Price)
                return true;
            return false;
        }
        public string SelectProductToPurchase(Item currentSelection, Purchase purchase, List<string> transactionLog)
        {
            // if CheckBalanceForItem() == true
            if (CheckBalanceForItem(currentSelection) == true)
            {
                Balance -= currentSelection.Price;
                transactionLog.Add($"{DateTime.Now} {currentSelection.Name} {currentSelection.SlotId}: ${currentSelection.Price} ${Balance}");
                return "";

            }
            //perform
            //update balance
            // else
            // no purchase; same balance
            else
            {
                return "Balance Insufficient for purchase.";
            }

        }
        public string FinishTransaction(List<string> transactionLog)
        {
            decimal cents = Balance * 100;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            decimal startBalance = 0M;

            while (cents >= 25)
            {
                quarters++;
                startBalance += 0.25M;
                cents = cents - 25;
            }
            while (cents>= 10)
            {
                dimes++;
                startBalance += 0.10M;
                cents = cents - 10;
            }
            while (cents >= 5)
            {
                nickels++;
                startBalance += 0.05M;
                cents = cents - 5;
            }

            Balance = 0.00M;
            transactionLog.Add($"{DateTime.Now} GIVE CHANGE: ${startBalance} $0.00");
            return $"${startBalance} dispensed. {quarters} quarter(s), {dimes} dime(s), {nickels} nickel(s) returned.\nBalance is now $0.00";
        }

            // update balance method

            // is it affordable? method

            // buy this item method

    }
}
