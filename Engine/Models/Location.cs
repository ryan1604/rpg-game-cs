using Newtonsoft.Json;

namespace Engine.Models
{
    public class Location(int xCoordinate, int yCoordinate, string name, string description, string imageName)
    {
        public int XCoordinate { get; } = xCoordinate;
        public int YCoordinate { get; } = yCoordinate;
        [JsonIgnore]
        public string Name { get; } = name;
        [JsonIgnore]
        public string Description { get; } = description;
        [JsonIgnore]
        public string ImageName { get; } = imageName;
        [JsonIgnore]
        public List<Quest> QuestsAvailableHere { get; } = new List<Quest>();
        [JsonIgnore]
        public List<MonsterEncounter> MonstersHere { get; } = new List<MonsterEncounter>();
        [JsonIgnore]
        public Trader TraderHere { get; set; }

        public void AddMonster(int monsterID, int chanceOfEncountering)
        {
            if (MonstersHere.Exists(m => m.MonsterID == monsterID))
            {
                MonstersHere.First(m => m.MonsterID == monsterID).ChanceOfEncountering = chanceOfEncountering;
            } else
            {
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
            }
        }
    }
}
