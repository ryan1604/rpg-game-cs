using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class MonsterEncounter(int monsterID, int chanceOfEncountering)
    {
        public int MonsterID { get; set; } = monsterID;
        public int ChanceOfEncountering { get; set; } = chanceOfEncountering;
    }
}
