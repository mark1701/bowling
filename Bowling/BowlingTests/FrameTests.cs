﻿using Bowling;
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
        public void NotAllPinsDownDoesNotRequireBonusPoints()
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
        public void ScoreIsTheSumOfTwoBaseRollsIfTheirSumIsLesserThenTen()
        {
            var rolls = new List<Roll> { new Roll(4), new Roll(2) };
            var expectedResult = 4 + 2;

            var frame = FrameFactory.CreateFrame(rolls);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }

        [Test]
        public void ScoreIsTenPlusTheNextRollIfScoreInTwoRollsIsTen()
        {
            var baseRolls = new List<Roll> { new Roll(4), new Roll(6) };
            var followingRolls = new List<Roll> { new Roll(4), new Roll(5) };
            var expectedResult = 10 + 4;

            var frame = FrameFactory.CreateFrame(baseRolls);
            frame.ApplyBonus(followingRolls);

            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }

        [Test]
        public void ScoreIsTenPlusTheNextTwoRollsIfFirstRollScoreIsTen()
        {
            var baseRolls = new List<Roll> { new Roll(10) };
            var followingRolls = new List<Roll> { new Roll(4), new Roll(5) };
            var expectedResult = 10 + 4 + 5;

            var frame = FrameFactory.CreateFrame(baseRolls);
            frame.ApplyBonus(followingRolls);

            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }
    }
}
