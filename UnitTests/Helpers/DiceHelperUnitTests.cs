﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Mine.Helpers;

namespace UnitTests.Helpers
{
    [TestFixture]
    public class DiceHelperTests
    {
        [Test]
        public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
        {
            //Arange

            //Act
            var result = DiceHelper.RollDice(0, 1);

            //Reset

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_Valid_Roll_1_Dice_6_Should_Return_Between_1_And_6()
        {
            //Arange

            //Act
            var result = DiceHelper.RollDice(1, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 1);
            Assert.AreEqual(true, result <= 6);
        }
    }
}
