﻿using System;
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

        public Monster(string name, string imageName, int maximumHitPoints, int hitPoints,
            int minDamage, int maxDamage, int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = $"/Engine;component/Images/Monsters/{imageName}";
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = hitPoints;
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            Gold = rewardGold;
        }
    }
}
