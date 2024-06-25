namespace SOSCSRPG.Models
{
    public class ItemQuantity(GameItem item, int quantity)
    {   
        private readonly GameItem _gameItem = item;

        public int ItemID => _gameItem.ItemTypeID;
        public int Quantity { get; } = quantity;

        public string ItemQuantityDescription => $"{Quantity} {_gameItem.Name}";
    }
}
