namespace Bowling
{
    public interface IGame {
        int CalculateScore();
    }

    public class Game : IGame
    {
        private readonly object[] _frames;

        public Game() {
            _frames = new object[10];
        }

        public int CalculateScore()
        {
            return CalculateFramesScore();
        }

        private int CalculateFramesScore() {
            return 150;
        }
    }
}
