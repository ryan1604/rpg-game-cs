using Engine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class PlayerAttribute(string key, string displayName, string diceNotation, int baseValue, int modifiedValue) : INotifyPropertyChanged
    {
        public string Key { get; } = key;
        public string DisplayName { get; } = displayName;
        public string DiceNotation { get; } = diceNotation;
        public int BaseValue { get; set; } = baseValue;
        public int ModifiedValue { get; set; } = modifiedValue;

        public event PropertyChangedEventHandler PropertyChanged;

        public PlayerAttribute(string key, string displayName, string diceNotation) :
            this(key, displayName, diceNotation, DiceService.GetInstance.Roll(diceNotation).Value)
        { 
        }
        
            public PlayerAttribute(string key, string displayName, string diceNotation, int baseValue)
            : this(key, displayName, diceNotation, baseValue, baseValue)
        {
        }

        public void ReRoll()
        {
            BaseValue = DiceService.GetInstance.Roll(DiceNotation).Value;
            ModifiedValue = BaseValue;
        }
    }
}
