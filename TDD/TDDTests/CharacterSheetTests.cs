using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Evercraft;

namespace TDDTests
{
    [TestClass]
    public class CharacterSheetTests
    {
        private CharacterSheet _character;

        [TestInitialize]
        public void Setup()
        {
            _character = new CharacterSheet("Awesome");
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
            _character.Dexterity.SetValue(10);
            Assert.AreEqual(_character.GetModifiedArmorClass(), 10);
        }

        [TestMethod]
        public void CharacterHasDefaultHitPoints()
        {
            Assert.AreEqual(_character.HitPoints, 5);
        }

        [TestMethod]
        public void CharacterKnowsWhenItsDead()
        {
            _character.TakeDamage(Int32.MaxValue);
            Assert.IsTrue(_character.IsDead);
        }

        [TestMethod]
        public void ArmorClassModifiedByDexterity()
        {
            _character.Dexterity.SetValue(14);

            Assert.AreEqual(12, _character.GetModifiedArmorClass());
        }
    }
}
