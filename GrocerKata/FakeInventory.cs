﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerKata
{
    public static class FakeInventory
    {
        public static Dictionary<string, FakeInventoryItem> Inventory = new Dictionary<string, FakeInventoryItem>
        {
            {"hamburger", new FakeInventoryItem("hamburger", 5.99m, -1, -1, 0) },
            {"apple", new FakeInventoryItem("apple", 2.99m, 1.99m, -1, 0) },
            {"banana", new FakeInventoryItem("banana", 1.49m, -1m, 0.99m, 0) },
            {"soup", new FakeInventoryItem("soup", 2.49m, -1m, 1.99m, 5) }
        };
    }

    public class FakeInventoryItem
    {
        string Name { get; set; }
        decimal PricePerUnit { get; set; }
        decimal MarkDownPrice { get; set; }
        decimal SpecialPrice { get; set; }
        decimal SpecialLimit { get; set; }

        public FakeInventoryItem(string name, decimal pricePerUnit, decimal markdownPrice, decimal specialPrice, decimal specialLimit)
        {
            Name = name;
            PricePerUnit = PricePerUnit;
            MarkDownPrice = markdownPrice;
            SpecialPrice = specialPrice;
            SpecialLimit = specialLimit;
        }
    }
}
