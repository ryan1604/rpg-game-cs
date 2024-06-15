using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Trader(string name) : BaseNotificationClass
    {
        public string Name { get; set; } = name;

        public ObservableCollection<GameItem> Inventory { get; set; } = new ObservableCollection<GameItem>();

        public void AddItemToInventory(GameItem item)
        {
            Inventory.Add(item);
        }

        public void RemoveItemFromInventory(GameItem item)
        {
            Inventory.Remove(item);
        }
    }
}
