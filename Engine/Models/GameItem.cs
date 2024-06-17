using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem(GameItem.ItemCategory category, int itemTypeID, string name, int price, 
        bool isUnique = false, int minDamage = 0, int maxDamage = 0)
    {
        public enum ItemCategory
        {
            Miscellaneous,
            Weapon
        }

        public ItemCategory Category { get; } = category;
        public int ItemTypeID { get; } = itemTypeID;
        public string Name { get; } = name;
        public int Price { get; } = price;
        public bool IsUnique { get; } = isUnique;
        public int MinimumDamage { get; } = minDamage;
        public int MaximumDamage { get; } = maxDamage;

        public GameItem Clone()
        {
            return new GameItem(Category, ItemTypeID, Name, Price, IsUnique, MinimumDamage, MaximumDamage);
        }
    }
}
