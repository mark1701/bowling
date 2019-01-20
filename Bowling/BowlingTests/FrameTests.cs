using Bowling;
using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void MaximumScore() {
            var maximumScore = 30;

            IFrame frame = new Frame(2,2);
            var calculatedValue = frame.CalculateScore();

            Assert.IsTrue(calculatedValue <= maximumScore);
        }

        [Test]
        public void MinimumScore()
        {
            var minimumScore = 0;

            IFrame frame = new Frame(2,2);
            var calculatedValue = frame.CalculateScore();

            Assert.IsTrue(calculatedValue >= minimumScore);
        }
    }
}
