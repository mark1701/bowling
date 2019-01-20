using Bowling;
using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void FrameMaximumScore() {
            var maxValue = 30;

            IFrame frame = new Frame();
            var calculatedValue = frame.CalculateScore();

            Assert.IsTrue(calculatedValue <= maxValue);
        }
    }
}
