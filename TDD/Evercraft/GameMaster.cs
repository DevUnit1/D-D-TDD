using System;

namespace Evercraft
{
    public class GameMaster
    {
        public void ResolveCombat(int roll, CharacterSheet attacker, CharacterSheet defender)
        {

            if (attacker.Attack(roll, defender))
            {
                defender.TakeDamage(CalculateDamage(roll, attacker));
            }
        }

        public int CalculateDamage(int roll, CharacterSheet attacker)
        {
            var damage = 1 + attacker.Strength.Modifier;

            if (roll == 20)
            {
                damage *= 2;
            }

            return Math.Max(1,damage);
        }
    }
}
