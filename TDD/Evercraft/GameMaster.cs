namespace Evercraft
{
    public class GameMaster
    {
        public void ResolveCombat(int roll, CharacterSheet attacker, CharacterSheet defender)
        {

            if (attacker.Attack(roll, defender))
            {
                defender.TakeDamage(CalculateDamage(roll));
            }
        }

        public int CalculateDamage(int roll)
        {
            var damage = 1;
            if (roll == 20)
            {
                damage *= 2;
            }

            return damage;
        }
    }
}
