﻿using System;
using Evercraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDTests
{
    [TestClass]
    public class AttackTests
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
        public void CharacterCanAttack()
        {
            int roll = 10;

            Assert.IsTrue(Runner.AttackTest(roll, _character, _opponent));
        }

        [TestMethod]
        public void CharacterCanMiss()
        {
            int roll = 10;
            _opponent.ArmorClass = 1000000;

            Assert.IsFalse(Runner.AttackTest(roll, _character, _opponent));
        }

        private static class Runner
        {
            public static bool AttackTest(int roll, CharacterSheet attacker, CharacterSheet defender)
            {
                return attacker.Attack(roll, defender);
            }
        }
    }
}
