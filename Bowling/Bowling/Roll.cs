namespace Bowling
{
    public class Roll
    {
        private readonly int _score;

        public Roll(int score) {
            _score = score;
        }

        public int GetScore() {
            return _score;
        }
    }
}
