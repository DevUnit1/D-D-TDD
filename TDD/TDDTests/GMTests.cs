using Evercraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDTests
{
    [TestClass]
    public class GMTests
    {
        private GameMaster _gm;
        private CharacterSheet attacker;
        private CharacterSheet defender;

        [TestInitialize]
        public void Setup()
        {
            _gm = new GameMaster();
            attacker = new CharacterSheet("Awesome");
            defender = new CharacterSheet("ex-Orc");
        }

        [TestMethod]
        public void GMCanResolveCombat()
        {
            int roll = 10;
            _gm.ResolveCombat(roll, attacker, defender);
        }

        [TestMethod]
        public void SucessfulAttackDoesOneDamage()
        {
            int roll = 10;
            var HpBefore = defender.HitPoints;

            _gm.ResolveCombat(roll, attacker, defender);

            Assert.AreEqual(HpBefore-1, defender.HitPoints);
        }

        [TestMethod]
        public void CriticalHitsTakeDoubleDamage()
        {
            int roll = 20;
            var HpBefore = defender.HitPoints;

            _gm.ResolveCombat(roll, attacker, defender);

            Assert.AreEqual(HpBefore - 2, defender.HitPoints);
        }

        [TestMethod]
        public void CalculateDamageTakesStrengthIntoAccount()
        {
            var roll = 19;
            attacker.Strength.SetValue(14);

            var damage = _gm.CalculateDamage(roll, attacker);

            Assert.AreEqual(damage, 3);
        }

        [TestMethod]
        public void MinimumDamageIsAlwaysOne()
        {
            var roll = 19;
            attacker.Strength.SetValue(1);

            var damage = _gm.CalculateDamage(roll, attacker);

            Assert.AreEqual(damage, 1);
        }
    }
}
