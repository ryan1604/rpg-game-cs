using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }

        public Monster(string name, string imageName, int maximumHitPoints, int currentHitPoints,
            int minDamage, int maxDamage, int rewardExperiencePoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            ImageName = $"/Engine;component/Images/Monsters/{imageName}";
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
            RewardExperiencePoints = rewardExperiencePoints;
        }
    }
}
