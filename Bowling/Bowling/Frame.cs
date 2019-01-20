namespace Bowling
{
    public interface IFrame {
        int CalculateScore();
    }

    public class Frame : IFrame
    {
        private readonly int _firstRoll;
        private readonly int _secondRoll;

        public Frame (int firstRoll, int secondRoll) {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public int CalculateScore()
        {
            return _firstRoll + _secondRoll;
        }
    }
}
