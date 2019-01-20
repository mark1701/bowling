namespace Bowling
{
    public class Game
    {
        private readonly Frame[] _frames;

        private Game() {
            _frames = new Frame[10];
            for (var i = 0; i < _frames.Length; i++)
            {
                _frames[i] = Frame.GetEmptyFrame();
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
            var score = 0;

            foreach (var frame in _frames) {
                score += frame.CalculateScore();
            }

            return score;
        }
    }
}
