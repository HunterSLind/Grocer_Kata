using System;
using System.Collections.Generic;

namespace GrocerKata
{
    public class Cart
    {
        public Dictionary<string, int> Items = new Dictionary<string, int>();
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
    }
}
