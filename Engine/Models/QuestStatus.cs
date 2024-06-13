using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class QuestStatus(Quest quest)
    {
        public Quest PlayerQuest { get; set; } = quest;
        public bool IsCompleted { get; set; } = false;
    }
}
