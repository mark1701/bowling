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
                    var rollsFollowingTheFrame = GetTwoRollsIfExistent(i * 2 + 2);
                    frame.ApplyBonus(rollsFollowingTheFrame);
                }

                score += frame.CalculateScore();
            }

            return score;
        }

        private List<Roll> GetTwoRollsIfExistent(int startingRollIndex) {

            if (startingRollIndex >= _rollsData.Count) {
                return new List<Roll>();
            }

            var firstFollowingRollData = _rollsData[startingRollIndex];
            var secondFollowingRollData = _rollsData[startingRollIndex + 1];

            var followingRolls = new List<Roll> { new Roll(int.Parse(firstFollowingRollData)) };

            if (secondFollowingRollData == "X")
            {
                secondFollowingRollData = _rollsData[startingRollIndex + 2];
            }

            followingRolls.Add(new Roll(int.Parse(secondFollowingRollData)));

            return followingRolls;
        }

        private void GenerateFrames(List<string> rollsData)
        {
            for (int i = 0; i < rollsData.Count - 1; i += 2)
            {
                var firstRollData = rollsData[i];
                var firstRollValue = int.Parse(firstRollData);

                var secondRollData = rollsData[i + 1];
                var secondRollValue = 0;


                if (secondRollData != "X")
                {
                    secondRollValue = int.Parse(secondRollData);
                }

                if ((firstRollValue + secondRollValue) > 10) {
                    continue;
                }

                var rolls = new List<Roll> { new Roll(firstRollValue), new Roll(secondRollValue) };
                var frame = FrameFactory.CreateFrame(rolls);

                _frames.Add(frame);
            }
        }

        public bool HasFrames() => _frames.Count > 0;
    }
}
