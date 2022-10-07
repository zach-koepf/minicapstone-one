using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Capstone.Objects;

namespace Capstone
{
    public class Logger
    {
        // write each transaction to "Log.txt"
        // create a list of all transactions (each method in purchase)
        // list contains date time now, transaction, colon, deposit/spent/given change, new balance
        // transactions are FEED MONEY, (select product) Item.Name Item.SlotId, (finish transaction) GIVE CHANGE
        // open log.txt
        // use try-catch & catch IO Exception
        //in purchase: each transaction will need a name, an associated datetime.now, an associated start balance, & an associated end balance
        // list will include: DateTime.Now, string TransactionName, decimal StartBalance, decimal EndBalance 
        // for FEED MONEY: DT.Now, NAME: Money fed, EndBalance
        // for Select Product: DT.Now, Item.Name Item.SlotId: Item.Price, EndBalance
        // for Finish Transaction: DT.Now, GIVE MONEY: money given (1st balance), 0.00 (endBalance)

        public static void WriteFile(List<string> transactionLog)
        {
            //find location for file writing
            string directory = Environment.CurrentDirectory + @"\..\..\..\..\";
            string fileName = "Log.txt";
            string fullPath = Path.Combine(directory, fileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath)) // only write transactions since start of program, do not append
                {
                    // for each transaction
                    // update log
                    // transaction date, time, action, 1st dollar, 2nd dollar
                    // first dollar amount is the amount deposited, spent, or given as change.
                    // second dollar amount is the new balance.
                    // take log message for action (string)
                    // take in balance

                    /* The vending machine logs all transactions to prevent theft from the vending machine.
                    Each purchase must generate a line in a file called Log.txt.
                    The lines must follow the format shown in the following example.
                    The first dollar amount is the amount deposited, spent, or given as change.
                    The second dollar amount is the new balance.
                        01/01/2019 12:00:00 PM FEED MONEY: $5.00 $5.00 
                        01/01/2019 12:00:15 PM FEED MONEY: $5.00 $10.00 
                        01/01/2019 12:00:20 PM Crunchie B4 $1.75 $8.25 
                        01/01/2019 12:01:25 PM Cowtales B2 $1.50 $6.75 
                        01/01/2019 12:01:35 PM GIVE CHANGE: $6.75 $0.00
                    */
                    foreach (string transaction in transactionLog)
                    {
                        sw.WriteLine($"{transaction}");
                    }
                    
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Trouble opening \"Log.txt\"");
                Console.WriteLine(ex.Message);
            }
            
        }


// Display Sales Report, save report with date/time stamp

    }
}
