using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerKata
{
    public class PriceManager
    {
        public void UpdateItemPrice(string itemID, decimal price)
        {
            FakeInventory.Inventory[itemID].PricePerUnit = price;
        }

        public void UpdateItemSpecialPrice(string itemID, decimal price)
        {
            FakeInventory.Inventory[itemID].SpecialPrice = price;
        }

        public void UpdateItemSpecialLimit(string itemID, decimal limit)
        {
            FakeInventory.Inventory[itemID].SpecialLimit = limit;
        }

        public void UpdateItemMarkdownPrice(string itemID, decimal price)
        {
            FakeInventory.Inventory[itemID].MarkDownPrice = price;
        }
    }
}
