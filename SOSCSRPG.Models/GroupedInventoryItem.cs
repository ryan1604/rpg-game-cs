using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCSRPG.Models
{
    public class GroupedInventoryItem(GameItem item, int quantity) : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public GameItem Item { get; set; } = item;

        public int Quantity { get; set; } = quantity;
    }
}
