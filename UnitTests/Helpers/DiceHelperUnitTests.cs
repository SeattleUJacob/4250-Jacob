using System;
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

        [Test]
        public void RollDice_Invalid_Roll_Forced_1_Should_Return_1()
        {
            //Arange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForceRandomValue = 1;

            //Act
            var result = DiceHelper.RollDice(1, 1);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void RollDice_Valid_2_Dice_6_Should_Return_Between_2_and_12()
        {
            //Arange

            //Act
            var result = DiceHelper.RollDice(2, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 2);
            Assert.AreEqual(true, result <= 12);
        }

        [Test]
        public void RollDice_InValid_0_Dice_10_Should_Return_Zero()
        {
            //Arange

            //Act
            var result = DiceHelper.RollDice(0, 10);

            //Reset

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_InValid_1_Dice_0_Should_Return_Zero()
        {
            //Arange

            //Act
            var result = DiceHelper.RollDice(1, 0);

            //Reset

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_Valid_1_Dice_10_Fixed_5_Should_Return_5()
        {
            //Arange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForceRandomValue = 5;

            //Act
            var result = DiceHelper.RollDice(1, 10);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void RollDice_Valid_3_Dice_10_Fixed_5_Should_Return_15()
        {
            //Arange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForceRandomValue = 5;

            //Act
            var result = DiceHelper.RollDice(3, 10);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(15, result);
        }
    }
}
