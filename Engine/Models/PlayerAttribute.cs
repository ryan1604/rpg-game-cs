using Engine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class PlayerAttribute
    {
        public string Key { get; }
        public string DisplayName { get; }
        public string DiceNotation { get; }
        public int BaseValue { get; set; }
        public int ModifiedValue { get; set; }
        
        public PlayerAttribute(string key, string displayName, string diceNotation) :
            this(key, displayName, diceNotation, DiceService.GetInstance.Roll(diceNotation).Value)
        { 
        }
        
            public PlayerAttribute(string key, string displayName, string diceNotation, int baseValue)
            : this(key, displayName, diceNotation, baseValue, baseValue)
        {
        }

        public PlayerAttribute(string key, string displayName, string diceNotation, int baseValue, int modifiedValue)
        {
            Key = key;
            DisplayName = displayName;
            DiceNotation = diceNotation;
            BaseValue = baseValue;
            ModifiedValue = modifiedValue;
        }

        public void ReRoll()
        {
            BaseValue = DiceService.GetInstance.Roll(DiceNotation).Value;
            ModifiedValue = BaseValue;
        }
    }
}
