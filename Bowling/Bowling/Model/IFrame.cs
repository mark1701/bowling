using System.Collections.Generic;

namespace Bowling.Model
{
    public interface IFrame
    {
        int CalculateScore();

        bool IsBonusRequired();

        void ApplyBonus(List<Roll> followingRolls);
    }
}
