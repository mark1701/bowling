using System.Collections.Generic;

namespace Bowling.Model
{
    public class RegularFrame : Frame
    {
        public RegularFrame(List<Roll> rolls) : base (rolls){}

        public override int CalculateScore()
        {
            var score = 0;

            foreach (Roll roll in _baseRolls)
            {
                score += roll.GetScore();
            }
            return score;
        }

        public override bool IsBonusRequired() => false;
    }
}
