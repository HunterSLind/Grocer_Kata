using System;
using System.Collections.Generic;

namespace GrocerKata
{
    public class Cart
    {
        public Dictionary<string, decimal> Items = new Dictionary<string, decimal>();
        public void AddItem(string itemID)
        {
            if (!Items.ContainsKey(itemID))
            {
                Items.Add(itemID, 1);
            }
            else
            {
                Items[itemID] += 1;
            }
        }

        public void AddItem(string itemID, decimal weight)
        {
            if (!Items.ContainsKey(itemID))
            {
                Items.Add(itemID, weight);
            }
            else
            {
                Items[itemID] += weight;
            }
        }

        public void RemoveItem(string itemID)
        {
            
        }
    }
}
