using Bowling;
using NUnit.Framework;
using System;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void ScoreIsTheSumOfTwoRollsIfTheirSumIsLesserThenTen()
        {
            var firstRoll = new Roll(4);
            var secondRoll = new Roll(2);
            var expectedResult = 6;

            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }

        [Test]
        public void AllPinsDownInTwoRollsRequireBonusPoints() {
            var firstRoll = new Roll(4);
            var secondRoll = new Roll(6);
            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);

            Assert.IsTrue(frame.IsBonusRequired());
        }

        [Test]
        public void AllPinsDownOnTheFirstRollRequireBonusPoints()
        {
            var firstRoll = new Roll(10);
            var secondRoll = new Roll(0);
            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);

            Assert.IsTrue(frame.IsBonusRequired());
        }

        [Test]
        public void NotAllPinsDownDoesntRequireBonusPoints()
        {
            var firstRoll = new Roll(1);
            var secondRoll = new Roll(5);
            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);

            Assert.IsFalse(frame.IsBonusRequired());
        }

        [Test]
        public void CalculateScoreThrowsExceptionIfBonusIsRequiredButNotProvided() {

            var firstRoll = new Roll(1);
            var secondRoll = new Roll(9);
            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);

            Assert.That(() => frame.CalculateScore(),
            Throws.Exception
            .TypeOf<InvalidOperationException>()
            .With.Message
            .EqualTo("This frame require a bonus to be applied"));
        }
    }
}
