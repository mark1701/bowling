using NUnit.Framework;

namespace BowlingTests
{    
    public class Tests
    {
        [Test]
        public void MaximumGameScore() {
            var maximumGameScore = 300;
            var gameScore = 150;

            Assert.IsTrue(gameScore <= maximumGameScore);
        }
    }
}
