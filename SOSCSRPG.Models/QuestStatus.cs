using System.ComponentModel;

namespace SOSCSRPG.Models
{
    public class QuestStatus(Quest quest) : INotifyPropertyChanged
    {
        public Quest PlayerQuest { get; } = quest;
        public bool IsCompleted { get; set; } = false;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
