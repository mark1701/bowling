using Bowling.Model;
using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Frame : IFrame
    {
        private readonly List<AbstractRoll> _baseRolls;
        private List<AbstractRoll> _followingRolls;

        public Frame (List<AbstractRoll> rolls) {
            _baseRolls = rolls;
        }

        public int CalculateScore()
        {
            if (IsBonusRequired() && _followingRolls == null) {
                throw new InvalidOperationException("This frame require a bonus to be applied");
            }
            var score = 0;

            foreach (AbstractRoll roll in _baseRolls) {
                score += roll.GetScore();
            }
            return score;
        }

        public bool IsBonusRequired() {
            var sumOfBaseRolls = 0;

            foreach (AbstractRoll roll in _baseRolls)
            {
                sumOfBaseRolls += roll.GetScore();
            }
            return sumOfBaseRolls >= 10;
        }

    }
}
