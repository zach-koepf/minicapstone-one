using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Objects
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; }
        public string Message 
        { 
            get 
            {
                switch (Type.ToLower())
                {
                    case "chip":
                        return "Crunch Crunch, Yum!";
                    case "candy":
                        return "Munch Munch, Yum!";
                    case "drink":
                        return "Glug Glug, Yum!";
                    case "gum":
                        return "Chew Chew, Yum!";
                    default:
                        return "Error, did not set item.Message Properly. Type did not match candy/chip/drink/gum";
                }
            } 
        }
        public string SlotId { get; set; }
        public string Type { get; set; }
        public int Count { get; set; } = 5;
        public Item(string slotId, string name, decimal price, string type)
        {
            SlotId = slotId;
            Type = type;
            Name = name;
            Price = price;
        }
    }
}
