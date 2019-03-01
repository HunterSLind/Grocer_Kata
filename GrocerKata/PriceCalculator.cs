using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerKata
{
    public static class PriceCalculator
    {
        public static decimal CalculateCartPrice(Cart cart)
        {
            decimal price = 0;
            foreach(var item in cart.Items)
            {
                decimal thisItemPrice = 0.00m;
                if (FakeInventory.Inventory[item.Key].MarkDownPrice > 0)
                {
                    thisItemPrice = FakeInventory.Inventory[item.Key].MarkDownPrice;
                }
                else
                {
                    thisItemPrice = FakeInventory.Inventory[item.Key].PricePerUnit;
                }
                price += thisItemPrice;
            }
            return price;
        }
    }
}
