using Engine.Models;
using Engine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOSCSRPG.Core;

namespace Engine.Actions
{
    public class AttackWithWeapon : BaseAction, IAction
    {
        private readonly string _damageDice;

        public AttackWithWeapon(GameItem itemInUse, string damageDice) : base(itemInUse)
        {
            if (itemInUse.Category != GameItem.ItemCategory.Weapon)
            {
                throw new ArgumentException($"{itemInUse.Name} is not a weapon.");
            }

            if (string.IsNullOrWhiteSpace(damageDice))
            {
                throw new ArgumentException("damageDice must be valid dice notation.");
            }

            _damageDice = damageDice;
        }

        public void Execute(LivingEntity actor, LivingEntity target)
        {
            int damage = DiceService.GetInstance.Roll(_damageDice).Value;

            string actorName = (actor is Player) ? "You" : $"The {actor.Name.ToLower()}";
            string targetName = (target is Player) ? "you" : $"the {target.Name.ToLower()}";

            if (CombatService.AttackSucceeded(actor ,target))
            {
                ReportResults($"{actorName} hit {targetName} for {damage} point{(damage > 1 ? "s" : "")}.");
                target.TakeDamage(damage);
            }
            else
            {
                ReportResults($"{actorName} missed {targetName}.");
            }
        }
    }
}
