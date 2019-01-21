using System.Collections.Generic;

namespace Bowling.Model
{
    public class RegularFrame : Frame
    {
        public RegularFrame(List<Roll> rolls) : base (rolls){}

        public override int CalculateScore()
        {
            return _baseRolls[0].GetScore() + _baseRolls[1].GetScore();
        }

        public override bool IsBonusRequired() => false;

        public override void ApplyBonus(List<Roll> followingRolls) { }
    }
}
