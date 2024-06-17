using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Actions;

namespace Engine.Models
{
    public class GameItem(GameItem.ItemCategory category, int itemTypeID, string name, int price, 
        bool isUnique = false, AttackWithWeapon action = null)
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
        public AttackWithWeapon Action { get; set; } = action;

        public GameItem Clone()
        {
            return new GameItem(Category, ItemTypeID, Name, Price, IsUnique, Action);
        }

        public void PerformAction(LivingEntity actor, LivingEntity target)
        {
            Action?.Execute(actor, target);
        }
    }
}
