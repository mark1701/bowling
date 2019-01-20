namespace Bowling
{
    public class Frame
    {
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;
        private Frame _nextFrame;

        private Frame (Roll firstRoll, Roll secondRoll) {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public static Frame CreateFrameFromRolls(Roll firstRoll, Roll secondRoll) {
            return new Frame(firstRoll, secondRoll);
        }

        public int CalculateScore()
        {
            return _firstRoll.GetScore() + _secondRoll.GetScore();
        }

        public bool IsBonusRequired() {
            return CalculateScore() >= 10;
        }

        public void ApplyBonus(Frame nextFrame) {
            _nextFrame = nextFrame;
        }
    }
}
