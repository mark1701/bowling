using Bowling;
using NUnit.Framework;

namespace BowlingTests
{    
    public class GameTests
    {
        [Test]
        public void MaximumGameScore() {
            var maximumGameScore = 300;
            IGame game = new Game();

            Assert.IsTrue(game.CalculateScore() <= maximumGameScore);
        }
    }
}
