using Bowling;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void AllPinsDownInTwoRollsRequireBonusPoints() {
            var rolls = new List<Roll> { new Roll(4), new Roll(6) };
            var frame = new Frame(rolls);

            Assert.IsTrue(frame.IsBonusRequired());
        }

        [Test]
        public void AllPinsDownOnTheFirstRollRequireBonusPoints()
        {
            var rolls = new List<Roll> { new Roll(10) };
            var frame = new Frame(rolls);

            Assert.IsTrue(frame.IsBonusRequired());
        }

        [Test]
        public void NotAllPinsDownDoesntRequireBonusPoints()
        {
            var rolls = new List<Roll> { new Roll(1), new Roll(5) };
            var frame = new Frame(rolls);

            Assert.IsFalse(frame.IsBonusRequired());
        }

        [Test]
        public void CalculateScoreThrowsExceptionIfBonusIsRequiredButNotProvided() {

            var rolls = new List<Roll> { new Roll(9), new Roll(1) };
            var frame = new Frame(rolls);

            Assert.That(() => frame.CalculateScore(),
            Throws.Exception
            .TypeOf<InvalidOperationException>()
            .With.Message
            .EqualTo("This frame require a bonus to be applied"));

            rolls = new List<Roll> { new Roll(10), new Roll(0) };
            frame = new Frame(rolls);

            Assert.That(() => frame.CalculateScore(),
            Throws.Exception
            .TypeOf<InvalidOperationException>()
            .With.Message
            .EqualTo("This frame require a bonus to be applied"));
        }

        [Test]
        public void ScoreIsTheSumOfTwoRollsIfTheirSumIsLesserThenTen()
        {
            var rolls = new List<Roll> { new Roll(4), new Roll(2) };
            var expectedResult = 6;

            var frame = new Frame(rolls);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }
    }
}
