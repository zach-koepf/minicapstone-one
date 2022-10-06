using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Logger
    {
        // write each transaction to "Log.txt"
        
        public static void WriteFile()
        {
            //find location for file writing
            string directory = Environment.CurrentDirectory;
            string fileName = "Log.txt";
            string fullPath = Path.Combine(directory, fileName);

            using (StreamWriter sw = new StreamWriter(fullPath, true)) // append current file
            {
                // for each transaction
                // update log
                // transaction date, time, action, 1st dollar, 2nd dollar
                // first dollar amount is the amount deposited, spent, or given as change.
                // second dollar amount is the new balance.
                // take log message for action (string)
                // take in balance
                //sw.Write($"{DateTime.Now} {STRINGACTION} {} {Purchase.Balance}");
            }
        }
        
        
        // Display Sales Report, save report with date/time stamp

    }
}
