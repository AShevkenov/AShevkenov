using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
            List<Box> list = new List<Box>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] itemInfo = line.Split(' ');

                string serialNumber = itemInfo[0];
                string itemName = itemInfo[1];
                double itemQuantity = double.Parse(itemInfo[2]);
                double itemPrice = double.Parse(itemInfo[3]);

                Item item = new Item();
                {
                    item.Name = itemName;
                    item.Price = itemPrice;
                }

                Box info = new Box();
                {
                    info.SerialNumbers = serialNumber;
                    info.Item = item;
                    info.ItemQuantity = itemQuantity;
                    info.PriceForABox = itemQuantity * itemPrice;
                }

               
                list.Add(info);

                line = Console.ReadLine();

            }

            //            Print all the boxes ordered descending by price for a box, in the following format: 
            //{ boxSerialNumber}
            //            -- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //            -- ${ boxPrice}
            //            The price should be formatted to the 2nd digit after the decimal separator.

            List<Box> orderedBoxex = list.OrderByDescending(box => box.PriceForABox).ToList();

            foreach (Box box in orderedBoxex)
            {
                Console.WriteLine(box.SerialNumbers);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public string SerialNumbers { get; set; }
        public Item Item { get; set; }
        public double ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
    }
}
