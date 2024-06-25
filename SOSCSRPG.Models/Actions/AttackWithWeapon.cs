using SOSCSRPG.Models;
using SOSCSRPG.Core;
using SOSCSRPG.Models.Shared;

namespace SOSCSRPG.Models.Actions
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

            if (AttackSucceeded(actor ,target))
            {
                ReportResults($"{actorName} hit {targetName} for {damage} point{(damage > 1 ? "s" : "")}.");
                target.TakeDamage(damage);
            }
            else
            {
                ReportResults($"{actorName} missed {targetName}.");
            }
        }

        private static bool AttackSucceeded(LivingEntity attacker, LivingEntity target)
        {
            // Currently using the same formula as FirstAttacker initiative.
            // This will change as we include attack/defense skills,
            // armor, weapon bonuses, enchantments/curses, etc.
            int playerDexterity = attacker.GetAttribute("DEX").ModifiedValue *
                                  attacker.GetAttribute("DEX").ModifiedValue;
            int opponentDexterity = target.GetAttribute("DEX").ModifiedValue *
                                    target.GetAttribute("DEX").ModifiedValue;
            decimal dexterityOffset = (playerDexterity - opponentDexterity) / 10m;
            int randomOffset = DiceService.GetInstance.Roll(20).Value - 10;
            decimal totalOffset = dexterityOffset + randomOffset;

            return DiceService.GetInstance.Roll(100).Value <= 50 + totalOffset;
        }
    }
}
