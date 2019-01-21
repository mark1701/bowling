using System.Collections.Generic;

namespace Bowling
{
    public class SpareFrame : Frame
    {
        public SpareFrame(List<Roll> rolls) : base(rolls) {}

        public override int CalculateScore()
        {
            if (_followingRolls == null || _followingRolls.Count < 1)
            {
                throw new System.InvalidOperationException("This frame requires a bonus in order to calculate the score");
            }

            var firstFollowingRollScore = _followingRolls[0].GetScore();

            return 10 + firstFollowingRollScore;
        }
        public override bool IsBonusRequired() => true;

        public override void ApplyBonus(List<Roll> followingRolls) {
            _followingRolls = followingRolls;
        }
    }
}
