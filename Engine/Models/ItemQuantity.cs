using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity(GameItem item, int quantity)
    {   
        private readonly GameItem _gameItem = item;

        public int ItemID => _gameItem.ItemTypeID;
        public int Quantity { get; } = quantity;

        public string ItemQuantityDescription => $"{Quantity} {_gameItem.Name}";
    }
}
