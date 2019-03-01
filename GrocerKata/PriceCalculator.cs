using System;

namespace GrocerKata
{
    public static class PriceCalculator
    {
        public static decimal CalculateCartPrice(Cart cart)
        {
            decimal price = 0;
            foreach (var item in cart.Items)
            {
                decimal thisItemPrice = 0.00m;
                FakeInventoryItem inventoryItem = FakeInventory.Inventory[item.Key];
                if (inventoryItem.SpecialPrice > 0)
                {
                    thisItemPrice = inventoryItem.SpecialPrice;
                }
                else if (inventoryItem.MarkDownPrice > 0)
                {
                    thisItemPrice = inventoryItem.MarkDownPrice;
                }
                else
                {
                    thisItemPrice = inventoryItem.PricePerUnit;
                }
                price += Math.Round(thisItemPrice * item.Value, 2, MidpointRounding.AwayFromZero);
            }
            return price;
        }
    }
}
