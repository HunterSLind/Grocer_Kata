using System;
using System.Linq;

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
                    // if the special limit is less than the number of this item in cart
                    if (inventoryItem.SpecialLimit < item.Value && inventoryItem.SpecialLimit > 0)
                    {
                        thisItemPrice += Math.Round(inventoryItem.SpecialPrice * inventoryItem.SpecialLimit, 2, MidpointRounding.AwayFromZero);
                        thisItemPrice += Math.Round(inventoryItem.PricePerUnit * (item.Value - inventoryItem.SpecialLimit), 2, MidpointRounding.AwayFromZero);
                        return thisItemPrice;
                    }
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

        private static void checkAllRedeemableDeals(Cart cart)
        {
            foreach(var item in cart.Items.Keys)
            {
                if(FakeDeals.SpecialtyDictionary.ContainsKey(item))
                {
                    SpecialtyDeal deal = FakeDeals.SpecialtyDictionary[item];
                    // if the cart contains the item you must buy, in a quantity equal to or greater than the amount you must buy it at.
                    if(cart.Items.Keys.Contains(deal.Buy) && cart.Items[item] >= deal.BuyNum)
                    {
                        // find out how many times greater
                        // by dividing items[item] by BuyNum
                        decimal numDeals = cart.Items[item] / deal.BuyNum; // 8 apples in cart, you have to buy 4 to get the deal
                        // if the number of times the deal is qualified in the cart is greater than the number of times it's redeemable
                        if (numDeals > deal.MaxTimes)
                        {
                            // set numdeals to maxtimes.
                            numDeals = deal.MaxTimes; // only redeemable once
                        }

                    }
                }
            }
        }
    }
}
