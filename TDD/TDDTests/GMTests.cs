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
        public void CriticalHitsTakeTwoDamage()
        {
            int roll = 20;
            var HpBefore = defender.HitPoints;

            _gm.ResolveCombat(roll, attacker, defender);

            Assert.AreEqual(HpBefore - 2, defender.HitPoints);
        }
    }
}
