using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void FrameMaximumScore() {
            var maxValue = 30;
            var actualValue = 15;

            Assert.IsTrue(actualValue <= maxValue);
        }
    }
}
