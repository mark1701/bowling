using Bowling;
using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void EmptyFrameHasZeroScore() {
            var frame = Frame.GetEmptyFrame();
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(0, calculatedValue);
        }

        [Test]
        public void ScoreIsTheSumOfTwoRolls()
        {
            var firstRoll = 4;
            var secondRoll = 12;
            var expectedResult = firstRoll + secondRoll;

            var frame = Frame.GetFrameFromScore(firstRoll, secondRoll);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }
    }
}
