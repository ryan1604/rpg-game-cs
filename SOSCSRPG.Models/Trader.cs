namespace SOSCSRPG.Models
{
    public class Trader(int id, string name) : LivingEntity(name, 9999, 9999, new List<PlayerAttribute>(), 9999)
    {
        public int ID { get; } = id;
    }
}
