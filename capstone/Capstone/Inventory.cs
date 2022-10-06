﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Capstone.Objects;
namespace Capstone
{
    class Inventory
    {
        public static List<Item> GetInventory()
        {
            List<Item> inventory = new List<Item>();
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
                        inventory.Add(newItem);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return inventory;
        }
    }
}