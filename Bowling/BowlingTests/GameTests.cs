using Bowling;
using NUnit.Framework;

namespace BowlingTests
{    
    public class GameTests
    {
        [Test]
        public void MaximumScore() {
            var maximumScore = 300;
            IGame game = new Game();

            Assert.IsTrue(game.CalculateScore() <= maximumScore);
        }

        public void MinimumScore()
        {
            var minimumScore = 0;
            IGame game = new Game();

            Assert.IsTrue(game.CalculateScore() >= minimumScore);
        }
    }
}
