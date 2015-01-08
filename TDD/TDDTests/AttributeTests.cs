using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Evercraft;

namespace TDDTests
{
    [TestClass]
    public class AttributeTests
    {
        private CharacterAttribute stat;

        [TestInitialize]
        public void Setup()
        {
            stat = new CharacterAttribute();
        }
        [TestMethod]
        public void AttributeTypeContainsDataAboutAttribute()
        {
            var statValue = stat.GetValue();

            Assert.AreEqual(10,statValue);
        }

        [TestMethod]
        public void AttributesCanBetSet()
        {
            stat.SetValue(11);

            Assert.AreEqual(11, stat.GetValue());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValueCanNotBeLessThanOne()
        {
            stat.SetValue(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValueCanNotBeGreaterThanTwenty()
        {
            stat.SetValue(21);
        }

        [TestMethod]
        public void ModifierIsZeroAtValueTen()
        {
            stat.SetValue(10);
            Assert.AreEqual(0, stat.Modifier);
        }

        [TestMethod]
        public void ModifierIsCalulatedCorrectly()
        {
            stat.SetValue(19);

            Assert.AreEqual(4,stat.Modifier);
        }

        [TestMethod]
        public void ModifierIsCalulatedCorrectlyAndIsNegative()
        {
            stat.SetValue(2);

            Assert.AreEqual(-4, stat.Modifier);
        }
    }
}
