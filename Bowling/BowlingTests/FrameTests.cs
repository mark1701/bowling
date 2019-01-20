using Bowling;
using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void EmptyFrameHasZeroScore() {
            var frame = Frame.GetNewFrame();
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(0, calculatedValue);
        }

        [Test]
        public void ScoreIsTheSumOfTwoRolls()
        {
            var firstRoll = new Roll(4);
            var secondRoll = new Roll(12);
            var expectedResult = 16;

            var frame = Frame.GetFrameFromRolls(firstRoll, secondRoll);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }
    }
}
