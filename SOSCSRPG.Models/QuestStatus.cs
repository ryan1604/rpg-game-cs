using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCSRPG.Models
{
    public class QuestStatus(Quest quest) : INotifyPropertyChanged
    {
        public Quest PlayerQuest { get; } = quest;
        public bool IsCompleted { get; set; } = false;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
