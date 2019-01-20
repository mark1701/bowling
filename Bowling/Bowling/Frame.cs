namespace Bowling
{
    public class Frame
    {
        private readonly int _firstRoll;
        private readonly int _secondRoll;

        private Frame (int firstRoll, int secondRoll) {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public static Frame GetEmptyFrame() {
            return new Frame(0, 0);
        }

        public static Frame GetFrameFromScore(int firstRoll, int seconRoll) {
            return new Frame(firstRoll, seconRoll);
        }

        public int CalculateScore()
        {
            return _firstRoll + _secondRoll;
        }
    }
}
