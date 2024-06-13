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
        public int ID { get; set; } = id;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public List<ItemQuantity> ItemsToComplete { get; set; } = itemsToComplete;
        public int RewardExperiencePoints { get; set; } = rewardExperiencePoints;
        public int RewardGold { get; set; } = rewardGold;
        public List<ItemQuantity> RewardItems { get; set; } = rewardItems;
    }
}
