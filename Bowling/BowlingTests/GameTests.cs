using Bowling;
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
            var rollsData = GameTestsData.GetTestSequence();
            var game = new Game(rollsData);

            Assert.IsTrue(game.HasFrames());
        }

        [Test, TestCaseSource(typeof(GameTestsData), nameof(GameTestsData.TestCases))]
        public int GameScoreMatchesExpectedResult(List<string> rollsData) {
            var game = new Game(rollsData);
            return game.CalculateScore();
        }

        [Test]
        public void TheScoreOfAGameWith1SpareRollAnd1RegularRollIsTheSumOfTheRollsPlus1Bonus()
        {
            var firstRoll = "3";
            var secondRoll = "7";
            var thirdRoll = "3";
            var fourthRoll = "5";
            var expectedResult = (10 + 3) + (3 + 5);

            var rollsData = new List<string>() { firstRoll, secondRoll, thirdRoll, fourthRoll };
            var game = new Game(rollsData);

            var actualResult = game.CalculateScore();

            Assert.AreEqual(expectedResult, actualResult);
        }

        private class GameTestsData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new List<string>() { "3", "5" }).Returns(8);
                }
            }

            public static List<string> GetTestSequence()
            {
                return new List<string>()
                {
                    //1
                    "1",
                    "1",
                    //2
                    "1",
                    "9",
                    //3
                    "1",
                    "1",
                    //4
                    "10",
                    "X",
                    //5
                    "1",
                    "1",
                    //6
                    "1",
                    "1",
                    //7
                    "1",
                    "1",
                    //8
                    "1",
                    "1",
                    //9
                    "1",
                    "1",
                    //10
                    "1",
                    "1",
                    //11
                    "1",
                    "1",
                    //12
                    "1",
                    "1",
                };
            }                       
        }
    }
}