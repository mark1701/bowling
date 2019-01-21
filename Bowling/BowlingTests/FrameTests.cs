using Bowling;
using Bowling.Model;
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
            var frame = FrameFactory.CreateFrame(rolls);

            Assert.IsTrue(frame.IsBonusRequired());
        }

        [Test]
        public void AllPinsDownOnTheFirstRollRequireBonusPoints()
        {
            var rolls = new List<Roll> { new Roll(10) };
            var frame = FrameFactory.CreateFrame(rolls);

            Assert.IsTrue(frame.IsBonusRequired());
        }

        [Test]
        public void NotAllPinsDownDoesntRequireBonusPoints()
        {
            var rolls = new List<Roll> { new Roll(1), new Roll(5) };
            var frame = FrameFactory.CreateFrame(rolls);

            Assert.IsFalse(frame.IsBonusRequired());
        }

        [Test]
        public void CalculateScoreThrowsExceptionIfBonusIsRequiredButNotProvided() {

            var rolls = new List<Roll> { new Roll(9), new Roll(1) };
            var frame = FrameFactory.CreateFrame(rolls);

            Assert.That(() => frame.CalculateScore(),
            Throws.Exception
            .TypeOf<InvalidOperationException>()
            .With.Message
            .EqualTo("This frame requires a bonus in order to calculate the score"));

            rolls = new List<Roll> { new Roll(10), new Roll(0) };
            frame = FrameFactory.CreateFrame(rolls);

            Assert.That(() => frame.CalculateScore(),
            Throws.Exception
            .TypeOf<InvalidOperationException>()
            .With.Message
            .EqualTo("This frame requires a bonus in order to calculate the score"));
        }

        [Test]
        public void ScoreIsTheSumOfTwoRollsIfTheirSumIsLesserThenTen()
        {
            var rolls = new List<Roll> { new Roll(4), new Roll(2) };
            var expectedResult = 6;

            var frame = FrameFactory.CreateFrame(rolls);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }
    }
}
