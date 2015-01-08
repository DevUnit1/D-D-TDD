using Microsoft.VisualStudio.TestTools.UnitTesting;
using Evercraft;

namespace TDDTests
{
    [TestClass]
    public class CharacterSheetTests
    {
        [TestMethod]
        public void CharacterSheetHasName()
        {
            var character = new CharacterSheet("Awesome");

            Assert.AreEqual("Awesome", character.Name);
        }
    }
}
