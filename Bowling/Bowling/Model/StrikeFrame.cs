using System.Collections.Generic;

namespace Bowling
{
    public class StrikeFrame : Frame
    {
        public StrikeFrame(List<Roll> rolls) : base(rolls) { }

        public override int CalculateScore()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsBonusRequired() => true;

        public override void ApplyBonus(List<Roll> followingRolls) { }
    }
}
