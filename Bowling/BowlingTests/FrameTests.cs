using Bowling;
using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void MaximumScore() {
            var maximumScore = 30;

            var frame = Frame.GetEmptyFrame();
            var calculatedValue = frame.CalculateScore();

            Assert.IsTrue(calculatedValue <= maximumScore);
        }

        [Test]
        public void MinimumScore()
        {
            var minimumScore = 0;

            var frame = Frame.GetEmptyFrame();
            var calculatedValue = frame.CalculateScore();

            Assert.IsTrue(calculatedValue >= minimumScore);
        }
    }
}
