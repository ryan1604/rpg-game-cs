using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity(int itemID, int quantity)
    {
        public int ItemID { get; set; } = itemID;
        public int Quantity { get; set; } = quantity;
    }
}
