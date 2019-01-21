using System.Collections.Generic;

namespace Bowling
{
    public class StrikeRoll : Frame
    {
        public StrikeRoll(List<Roll> rolls) : base(rolls) { }

        public override int CalculateScore()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsBonusRequired()
        {
            throw new System.NotImplementedException();
        }
    }
}
