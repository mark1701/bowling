using Bowling.Model;
using System.Collections.Generic;

namespace Bowling
{
    public static class FrameFactory
    {
        public static IFrame CreateFrame(List<Roll> rolls) {

            var firstRoll = rolls[0];
            if (firstRoll.GetScore() == 10) {
                return new StrikeFrame(rolls);
            }

            var secondRoll = rolls[1];
            if (firstRoll.GetScore() + secondRoll.GetScore() == 10)
            {
                return new SpareFrame(rolls);
            }

            return new RegularFrame(rolls);
        }
    }
}
