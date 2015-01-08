using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Evercraft;

namespace TDDTests
{
    [TestClass]
    public class CharacterSheetTests
    {
        private CharacterSheet _character;
        private CharacterSheet _opponent;

        [TestInitialize]
        public void Setup()
        {
            _character = new CharacterSheet("Awesome");
            _opponent = new CharacterSheet("Orc");
        }

        [TestMethod]
        public void CharacterSheetHasName()
        {
            Assert.AreEqual("Awesome", _character.Name);
        }

        [TestMethod]
        public void CharacterSheetHasAlignment()
        {

            _character.Alignment = Alignments.Good;

            Assert.AreEqual(Alignments.Good, _character.Alignment);
        }

        [TestMethod]
        public void CharacterHasDefaultArmorClass()
        {
            Assert.AreEqual(_character.ArmorClass, 10);
        }

        [TestMethod]
        public void CharacterHasDefaultHitPoints()
        {
            Assert.AreEqual(_character.HitPoints, 5);
        }

        [TestMethod]
        public void CharacterCanAttack()
        {
            int roll = 10;
            var successfulAttack = _character.Attack(roll, _opponent);

            Assert.IsTrue(successfulAttack);
        }

        [TestMethod]
        public void CharacterCanMiss()
        {
            int roll = 10;
            _opponent.ArmorClass = 1000000;

            var foiledAttack = _character.Attack(roll, _opponent);
            Assert.IsFalse(foiledAttack);
        }
    }
}
