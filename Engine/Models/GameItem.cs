﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem(int itemTypeID, string name, int price, bool isUnique = false)
    {
        public int ItemTypeID { get; set; } = itemTypeID;
        public string Name { get; set; } = name;
        public int Price { get; set; } = price;
        public bool IsUnique { get; set; } = isUnique;

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, IsUnique);
        }
    }
}
