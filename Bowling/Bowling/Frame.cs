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
            try
            {
                return _firstRoll.GetScore() + _secondRoll.GetScore();
            }
            catch (System.Exception e) {
                throw;
            }
        }

        public bool IsBonusRequired() {
            var sumOfBaseRolls = _firstRoll.GetScore() + _secondRoll.GetScore();
            return sumOfBaseRolls >= 10;
        }

        public void ApplyBonus(Frame nextFrame) {
            _nextFrame = nextFrame;
        }
    }
}
