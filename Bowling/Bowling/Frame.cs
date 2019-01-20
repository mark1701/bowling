using System;

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
            if (IsBonusRequired() && _nextFrame == null) {
                throw new InvalidOperationException("This frame require a bonus to be applied");
            }
            return _firstRoll.GetScore() + _secondRoll.GetScore();
        }

        public bool IsBonusRequired() {
            var sumOfBaseRolls = _firstRoll.GetScore() + _secondRoll.GetScore();
            return sumOfBaseRolls >= 10;
        }

    }
}
