using System;
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

    public static class FakeDeals
    {
        public static Dictionary<string, SpecialtyDeal> SpecialtyDictionary = new Dictionary<string, SpecialtyDeal>
        {
            {"banana", new SpecialtyDeal("apple", 4, "banana", 2, 0.50m, 1) } // buy 4 apples get 2 bananas for 50 cents, redeemable once
        };
    }

    public class SpecialtyDeal
    {
        public string Buy { get; set; }
        public decimal BuyNum { get; set; }

        public string Get { get; set; }
        public decimal GetNum { get; set; }
        public decimal GetFor { get; set; }

        public decimal MaxTimes { get; set; }

        public SpecialtyDeal(string buy, decimal buyNum, string get, decimal getNum, decimal getFor, decimal maxTimes)
        {
            Buy = buy;
            BuyNum = buyNum;
            Get = get;
            GetFor = getFor;
            MaxTimes = maxTimes;
        }
    }

    public class FakeInventoryItem
    {
        public string Name { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal MarkDownPrice { get; set; }
        public decimal SpecialPrice { get; set; }
        public decimal SpecialLimit { get; set; }

        public FakeInventoryItem(string name, decimal pricePerUnit, decimal markdownPrice, decimal specialPrice, decimal specialLimit)
        {
            Name = name;
            PricePerUnit = pricePerUnit;
            MarkDownPrice = markdownPrice;
            SpecialPrice = specialPrice;
            SpecialLimit = specialLimit;
        }


    }
}
