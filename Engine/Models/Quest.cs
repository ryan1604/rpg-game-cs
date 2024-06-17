using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete, 
        int rewardExperiencePoints, int rewardGold, List<ItemQuantity> rewardItems)
    {
        public int ID { get; } = id;
        public string Name { get; } = name;
        public string Description { get; } = description;
        public List<ItemQuantity> ItemsToComplete { get; } = itemsToComplete;
        public int RewardExperiencePoints { get; } = rewardExperiencePoints;
        public int RewardGold { get; } = rewardGold;
        public List<ItemQuantity> RewardItems { get; } = rewardItems;
    }
}
