namespace SOSCSRPG.Models
{
    public class MonsterEncounter(int monsterID, int chanceOfEncountering)
    {
        public int MonsterID { get; } = monsterID;
        public int ChanceOfEncountering { get; set; } = chanceOfEncountering;
    }
}
