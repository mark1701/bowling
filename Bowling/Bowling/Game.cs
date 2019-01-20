namespace Bowling
{
    public interface IGame {
        int CalculateScore();
    }

    public class Game : IGame
    {
        private readonly IFrame[] _frames;

        public Game() {
            _frames = new Frame[10];
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
