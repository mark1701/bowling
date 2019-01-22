﻿using Bowling;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace BowlingTests
{
    public class GameTests
    {
        [Test]
        public void LoadingRollsDataIntoAGameGenerateFrames()
        {
            var rollsData = new List<string>() { "1", "2", "3", "4" };
            var game = new Game(rollsData);

            Assert.IsTrue(game.HasFrames());
        }

        [Test, TestCaseSource(typeof(GameTestsData), nameof(GameTestsData.TestCases))]
        public int GameScoreMatchesExpectedResult(List<string> rollsData) {
            var game = new Game(rollsData);
            return game.CalculateScore();
        }
               
        private class GameTestsData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new List<string>() { "3", "5" }).Returns(3+5);
                    yield return new TestCaseData(new List<string>() { "3", "7", "3", "5" }).Returns((10 + 3) + (3 + 5));
                    yield return new TestCaseData(new List<string>() { "10", "X", "3", "5" }).Returns((10 + 3 + 5) + (3 + 5));
                }
            }
        }
    }
}