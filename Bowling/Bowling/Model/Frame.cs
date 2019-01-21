using Bowling.Model;
using System.Collections.Generic;

namespace Bowling
{
    public abstract class Frame : IFrame
    {
        internal readonly List<Roll> _baseRolls;

        public Frame (List<Roll> rolls) {
            _baseRolls = rolls;
        }

        public abstract int CalculateScore();

        public abstract bool IsBonusRequired();
    }
}
