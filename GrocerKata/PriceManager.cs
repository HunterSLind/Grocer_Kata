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
    }
}
