using Bowling;
using Bowling.Model;
using NUnit.Framework;
using System.Collections.Generic;

namespace BowlingTests
{
    public class GameTests
    {
        private List<IFrame> _frames;

        [Test]
        public void CreateGame()
        {
            _frames = new List<IFrame>();
            var rollsData = GameTestsData.GetTestSequence();

            for (int i = 0; i < rollsData.Count - 2; i += 2) {
                var firstRollData = rollsData[i];
                var secondRollData = rollsData[i + 1];

                var rolls = new List<Roll> { new Roll(int.Parse(firstRollData)) };

                if (secondRollData != "X") {
                    rolls.Add(new Roll(int.Parse(secondRollData)));
                }
                var frame = FrameFactory.CreateFrame(rolls);

                _frames.Add(frame);
            }

            Assert.IsTrue(_frames.Count > 1);
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
