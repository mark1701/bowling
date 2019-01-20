using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Frame
    {
        private readonly List<Roll> _baseRolls;
        private Frame _nextFrame;

        private Frame (List<Roll> rolls) {
            _baseRolls = rolls;
        }

        public static Frame CreateFrameFromRolls(List<Roll> rolls) {
            return new Frame(rolls);
        }

        public int CalculateScore()
        {
            if (IsBonusRequired() && _nextFrame == null) {
                throw new InvalidOperationException("This frame require a bonus to be applied");
            }
            var score = 0;

            foreach (Roll roll in _baseRolls) {
                score += roll.GetScore();
            }
            return score;
        }

        public bool IsBonusRequired() {
            var sumOfBaseRolls = 0;

            foreach (Roll roll in _baseRolls)
            {
                sumOfBaseRolls += roll.GetScore();
            }
            return sumOfBaseRolls >= 10;
        }

    }
}
