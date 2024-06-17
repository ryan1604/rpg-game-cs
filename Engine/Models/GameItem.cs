using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem(int itemTypeID, string name, int price, bool isUnique = false)
    {
        public int ItemTypeID { get; } = itemTypeID;
        public string Name { get; } = name;
        public int Price { get; } = price;
        public bool IsUnique { get; } = isUnique;

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, IsUnique);
        }
    }
}
