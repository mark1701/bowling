namespace Bowling
{
    public class Game
    {
        private IFrame[] _frames;

        private Game() {
            _frames = new Frame[10];
            for (var i = 0; i < _frames.Length; i++)
            {
                _frames[i] = new Frame();
            }
        }

        public static Game GetNewGame() {
            return new Game();
        }

        public int CalculateScore()
        {
            return CalculateFramesScore();
        }

        private int CalculateFramesScore() {
            var score = 150;
            return score;
        }
    }
}
