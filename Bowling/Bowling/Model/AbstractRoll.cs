namespace Bowling
{
    public class AbstractRoll
    {
        private readonly int _score;

        public AbstractRoll(int score) {
            _score = score;
        }

        public int GetScore() {
            return _score;
        }
    }
}
