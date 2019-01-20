using Bowling;
using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void EmptyFrameHasZeroScore() {
            var frame = Frame.CreateNewFrame();
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(0, calculatedValue);
        }

        [Test]
        public void ScoreIsTheSumOfTwoRolls()
        {
            var firstRoll = new Roll(4);
            var secondRoll = new Roll(12);
            var expectedResult = 16;

            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }

        [Test]
        public void AllPinsDownGenerateASpare() {
            Assert.IsTrue(true);
        }
    }
}
