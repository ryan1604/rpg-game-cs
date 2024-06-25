namespace SOSCSRPG.Models
{
    public class GameState(Player player, int x, int y)
    {
        public Player Player { get; init; } = player;
        public int XCoordinate { get; init; } = x;
        public int YCoordinate { get; init; } = y;
    }
}
