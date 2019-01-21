using System.Collections.Generic;

namespace Bowling
{
    public class SpareRoll : Frame
    {
        public SpareRoll(List<Roll> rolls) : base(rolls) {}

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
