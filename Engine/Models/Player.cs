using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        public string name { get; set; }
        public string characterClass { get; set; }
        public int hitPoints { get; set; }
        public int experiencePoints { get; set; }
        public int level { get; set; }
        public int gold { get; set; }
    }
}
