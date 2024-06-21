using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity(int itemID, int quantity)
    {
        public int ItemID { get; } = itemID;
        public int Quantity { get; } = quantity;

        public string ItemQuantityDescription => $"{Quantity} {ItemFactory.ItemName(ItemID)}";
    }
}
