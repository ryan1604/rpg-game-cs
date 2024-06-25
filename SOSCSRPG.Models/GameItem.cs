using SOSCSRPG.Models.Actions;
using Newtonsoft.Json;

namespace SOSCSRPG.Models
{
    public class GameItem(GameItem.ItemCategory category, int itemTypeID, string name, int price, 
        bool isUnique = false, IAction action = null)
    {
        public enum ItemCategory
        {
            Miscellaneous,
            Weapon,
            Consumable
        }

        [JsonIgnore]
        public ItemCategory Category { get; } = category;
        public int ItemTypeID { get; } = itemTypeID;
        [JsonIgnore]
        public string Name { get; } = name;
        [JsonIgnore]
        public int Price { get; } = price;
        [JsonIgnore]
        public bool IsUnique { get; } = isUnique;
        [JsonIgnore]
        public IAction Action { get; set; } = action;

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
