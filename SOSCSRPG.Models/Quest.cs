using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCSRPG.Models
{
    public class Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete, 
        int rewardExperiencePoints, int rewardGold, List<ItemQuantity> rewardItems)
    {
        public int ID { get; } = id;
        [JsonIgnore]
        public string Name { get; } = name;
        [JsonIgnore]
        public string Description { get; } = description;
        [JsonIgnore]
        public List<ItemQuantity> ItemsToComplete { get; } = itemsToComplete;
        [JsonIgnore]
        public int RewardExperiencePoints { get; } = rewardExperiencePoints;
        [JsonIgnore]
        public int RewardGold { get; } = rewardGold;
        [JsonIgnore]
        public List<ItemQuantity> RewardItems { get; } = rewardItems;

        [JsonIgnore]
        public string ToolTipContents =>
            Description + Environment.NewLine + Environment.NewLine +
            "Items to complete the quest" + Environment.NewLine +
            "===========================" + Environment.NewLine +
            string.Join(Environment.NewLine, ItemsToComplete.Select(i => i.ItemQuantityDescription)) +
            Environment.NewLine + Environment.NewLine +
            "Rewards\r\n" +
            "===========================" + Environment.NewLine +
            $"{RewardExperiencePoints} experience points" + Environment.NewLine +
            $"{RewardGold} gold pieces" + Environment.NewLine +
            string.Join(Environment.NewLine, RewardItems.Select(i => i.ItemQuantityDescription));
    }
}
