using Bowling.Model;
using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        private List<string> _rollsData;
        private List<IFrame> _frames;

        public Game(List<string> rollsData) {
            _rollsData = rollsData;
            _frames = new List<IFrame>();

            GenerateFrames(rollsData);
        }

        public int CalculateScore()
        {
            var score = 0;

            for (int i = 0; i < _frames.Count; i++)
            {
                var frame = _frames[i];
                if (frame.IsBonusRequired())
                {
                    var rollsFollowingTheFrame = GetTwoRollsIfExistent(i + 2);
                    frame.ApplyBonus(rollsFollowingTheFrame);
                }

                score += frame.CalculateScore();
            }

            return score;
        }

        private List<Roll> GetTwoRollsIfExistent(int startingRollIndex) {
            var firstFollowingRollData = _rollsData[startingRollIndex];
            var secondFollowingRollData = _rollsData[startingRollIndex + 1];

            var followingRolls = new List<Roll> { new Roll(int.Parse(firstFollowingRollData)) };

            if (secondFollowingRollData != "X")
            {
                followingRolls.Add(new Roll(int.Parse(secondFollowingRollData)));
            }

            return followingRolls;
        }

        private void GenerateFrames(List<string> rollsData)
        {
            for (int i = 0; i < rollsData.Count - 1; i += 2)
            {
                var firstRollData = rollsData[i];
                var secondRollData = rollsData[i + 1];

                var rolls = new List<Roll> { new Roll(int.Parse(firstRollData)) };

                if (secondRollData != "X")
                {
                    rolls.Add(new Roll(int.Parse(secondRollData)));
                }
                var frame = FrameFactory.CreateFrame(rolls);

                _frames.Add(frame);
            }
        }

        public bool HasFrames() => _frames.Count > 0;
    }
}
