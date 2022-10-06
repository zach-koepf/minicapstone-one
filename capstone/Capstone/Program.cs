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

            // display main menu
            UserInteraction.DisplayMainMenu();

            // read line from user
            string menuOption = Console.ReadLine();
            // try-catch parse from string to int
            // if correct input & number is 1 display main menu
            //                  number = 2 go to purchase process menu
            //                  number =3 finish transaction
            //if incorrection input display format exception
            // do different things based on numbers
        }
    }
}
