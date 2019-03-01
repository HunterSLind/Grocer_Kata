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
                if (FakeInventory.Inventory[item.Key].MarkDownPrice > 0)
                {
                    decimal thisItemPrice = FakeInventory.Inventory[item.Key].MarkDownPrice;
                    price += thisItemPrice;
                }
                else
                {
                    decimal thisItemPrice = FakeInventory.Inventory[item.Key].PricePerUnit;
                    price += thisItemPrice;
                }
            }
            return price;
        }
    }
}
