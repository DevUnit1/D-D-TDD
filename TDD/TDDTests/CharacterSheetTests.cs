using System.Runtime.InteropServices;
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
            Assert.AreEqual(_character.ArmorClass, 10);
        }
    }
}
