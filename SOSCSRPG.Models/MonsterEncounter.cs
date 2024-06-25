using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCSRPG.Models
{
    public class MonsterEncounter(int monsterID, int chanceOfEncountering)
    {
        public int MonsterID { get; } = monsterID;
        public int ChanceOfEncountering { get; set; } = chanceOfEncountering;
    }
}
