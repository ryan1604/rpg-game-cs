using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location(int xCoordinate, int yCoordinate, string name, string description, string imageName)
    {
        public int XCoordinate { get; } = xCoordinate;
        public int YCoordinate { get; } = yCoordinate;
        public string Name { get; } = name;
        public string Description { get; } = description;
        public string ImageName { get; } = imageName;
        public List<Quest> QuestsAvailableHere { get; } = new List<Quest>();
        public List<MonsterEncounter> MonstersHere { get; } = new List<MonsterEncounter>();
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

        public Monster GetMonster()
        {
            if (!MonstersHere.Any())
            {
                return null;
            }

            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncountering);

            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);

            int runningTotal = 0;

            foreach(MonsterEncounter monsterEncounter in MonstersHere)
            {
                runningTotal += monsterEncounter.ChanceOfEncountering;
                if (randomNumber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID);
                }
            }
            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);
        }
    }
}
