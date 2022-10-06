using System;
using Capstone.Objects;
using Capstone;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //inputCSV file
            bool isDone = false;

            while (isDone == false)
            {
            // display main menu

            UserInteraction.DisplayMainMenu();

            // read line from user
            string menuOption = Console.ReadLine();

             if (menuOption == "3")
                {
                    isDone = true;
                    break;
                }
             
            // try-catch parse from string to int
            // if correct input & number is 1 display main menu
            //                  number = 2 go to purchase process menu
            //                  number =3 finish transaction
            //if incorrection input display format exception
            // do different things based on numbers 
            }
           
        }
    }
}
