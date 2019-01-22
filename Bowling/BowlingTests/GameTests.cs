using Bowling;
using NUnit.Framework;
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

        public void TheScoreOfAGameWithTwoRollsIsTheSumOfTheTwoRolls() {

            var firstRoll = "3";
            var secondRoll = "5";
            var expectedResult = 8;

            var rollsData = new List<string>() { firstRoll, secondRoll };
            var game = new Game(rollsData);

            var actualResult = 8;

            Assert.AreEqual(expectedResult, actualResult);
        }

        private static class GameTestsData
        {
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
