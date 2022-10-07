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
            Inventory inventory = new Inventory();
            inventory.GetInventory();

            Purchase purchase = new Purchase();
            while (isDone == false)
            {
            // display main menu

            UserInteraction.DisplayMainMenu();
                
            // read line from user
            string menuOption = Console.ReadLine();

                if (menuOption == "3")  //Exit program selection
                {
                    isDone = true;
                    break;
                }
                else if (menuOption == "1")     //displays list of items
                {
                    UserInteraction.DisplayItems(inventory);
                }
                else if (menuOption == "2")     //enters purchase menu loop
                {
                    string purchaseMenueOption = Console.ReadLine();
                    bool purchaseComplete = false;

                    UserInteraction.PurchaseMenu(purchase);
                    while (purchaseComplete == false)
                    {
                        if (purchaseMenueOption == "3") //finish transaction menu uption
                        {
                            UserInteraction.FinishTransaction(purchase);
                            purchaseComplete = true;
                            break;
                        }
                        else if (purchaseMenueOption == "1")  // feeds money in, sets balance
                        {
                            UserInteraction.UserFeedMoney(purchase);
                        }
                        else if (purchaseMenueOption == "2") // purchase process, including item selection
                        {
                            // add select product
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry. Please enter 1, 2, or 3./n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine ("Invalid entry. Please enter 1, 2, or 3./n");
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
