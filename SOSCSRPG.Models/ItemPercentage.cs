namespace SOSCSRPG.Models
{
    public class ItemPercentage(int id, int percentage)
    {
        public int ID { get; } = id;
        public int Percentage { get; } = percentage;
    }
}
