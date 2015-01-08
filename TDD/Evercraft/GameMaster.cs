namespace Evercraft
{
    public class GameMaster
    {
        public void ResolveCombat(int roll, CharacterSheet attacker, CharacterSheet defender)
        {
            var damage = 1;
            if (roll == 20)
            {
                damage*=2;
            }
            if (attacker.Attack(roll, defender))
            {
                defender.TakeDamage(damage);
            }
        }
    }
}
