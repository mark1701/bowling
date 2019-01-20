using Bowling;
using NUnit.Framework;

namespace BowlingTests
{    
    public class GameTests
    {
        [Test]
        public void MaximumScore() {
            var maximumScore = 300;
            var game = Game.GetNewGame();

            Assert.IsTrue(game.CalculateScore() <= maximumScore);
        }

        [Test]
        public void MinimumScore()
        {
            var minimumScore = 0;
            var game = Game.GetNewGame();

            Assert.IsTrue(game.CalculateScore() >= minimumScore);
        }
    }
}
