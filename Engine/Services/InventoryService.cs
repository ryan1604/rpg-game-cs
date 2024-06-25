﻿using Engine.Models;

namespace Engine.Services
{
    public static class InventoryService
    {
        public static Inventory AddItem(this Inventory inventory, GameItem item)
        {
            return inventory.AddItems(new List<GameItem> {item});
        }

        public static Inventory AddItems(this Inventory inventory, IEnumerable<GameItem> items)
        {
            return new Inventory(inventory.Items.Concat(items));
        }

        public static Inventory RemoveItem(this Inventory inventory, GameItem item)
        {
            return inventory.RemoveItems(new List<GameItem> { item });
        }

        public static Inventory RemoveItems(this Inventory inventory, IEnumerable<GameItem> items)
        {
            // REFACTOR: Look for a cleaner solution, with fewer temporary variables.
            List<GameItem> workingInventory = inventory.Items.ToList();
            IEnumerable<GameItem> itemsToRemove = items.ToList();
            foreach (GameItem item in itemsToRemove)
            {
                workingInventory.Remove(item);
            }
            return new Inventory(workingInventory);
        }

        public static Inventory RemoveItems(this Inventory inventory, IEnumerable<ItemQuantity> itemQuantities)
        {
            // REFACTOR
            Inventory workingInventory = inventory;
            foreach (ItemQuantity itemQuantity in itemQuantities)
            {
                for (int i = 0; i < itemQuantity.Quantity; i++)
                {
                    workingInventory =
                        workingInventory
                            .RemoveItem(workingInventory
                                        .Items
                                        .First(item => item.ItemTypeID == itemQuantity.ItemID));
                }
            }
            return workingInventory;
        }
    }
}
